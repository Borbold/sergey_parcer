using System;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;

namespace SergeyParcesr {
    internal class FileHandling {
        private readonly StringParsing SP = new();
        private CancellationTokenSource readFileSource, readFilterSource;
        private DataTable dataTable;

        private readonly string _path;
        private readonly RichTextBox _outputTextBox;
        private readonly DataGridView _gridRows, _filterGridRows;
        private readonly ComboBox _filterSender, _filterReceiver, _filterAttribute, _filterCode;
        public FileHandling(string path, RichTextBox outputTextBox, DataGridView gridRows,
                ComboBox filterSender, ComboBox filterReceiver, ComboBox filterAttribute, ComboBox filterCode,
                DataGridView filterGridRows) {
            _path = path;
            _outputTextBox = outputTextBox;
            _gridRows = gridRows;
            readFileSource = new();
            readFilterSource = new();
            _filterSender = filterSender;
            _filterReceiver = filterReceiver;
            _filterAttribute = filterAttribute;
            _filterCode = filterCode;
            _filterGridRows = filterGridRows;
            dataTable = new();
            CreateDataBase();
        }

        private void CreateDataBase() {
            dataTable.Columns.Add("Номер", typeof(string));
            dataTable.Columns.Add("Тип", typeof(string));
            dataTable.Columns.Add("C/D", typeof(string));
            dataTable.Columns.Add("Отправитель", typeof(string));
            dataTable.Columns.Add("Приниматель", typeof(string));
            dataTable.Columns.Add("Аттрибут", typeof(string));
            dataTable.Columns.Add("Код", typeof(string));
            dataTable.Columns.Add("Данные", typeof(string));
        }

        private bool ReadString(char rS, ref string result) {
            if(rS == '\n') return true;
            result += rS;
            return false;
        }

        public void StopReadFile() {
            readFileSource.Cancel();
            readFilterSource.Cancel();
        }

        public void FilterDataGrid(string sender, string receiver, string attribute, string code) {
            readFilterSource = new();
            int firstEnd = _gridRows.RowCount / 6, firstStart = 0;

            CancellationToken readFilterToken = readFilterSource.Token;
            TaskFactory? readFilterFac = new(readFilterToken);
            _ = readFilterFac.StartNew(() => {
                FilterOutDataGrid(sender, receiver, attribute, code, firstStart, firstEnd);
                readFilterFac = null;
            }, readFilterToken);

            CancellationToken readFilterToken1 = readFilterSource.Token;
            TaskFactory? readFilterFac1 = new(readFilterToken1);
            _ = readFilterFac1.StartNew(() => {
                Thread.Sleep(1000);
                firstStart = firstEnd + _gridRows.RowCount / 6;
                FilterOutDataGrid(sender, receiver, attribute, code, firstEnd, firstStart);
                readFilterFac1 = null;
            }, readFilterToken1);

            CancellationToken readFilterToken2 = readFilterSource.Token;
            TaskFactory? readFilterFac2 = new(readFilterToken2);
            _ = readFilterFac2.StartNew(() => {
                Thread.Sleep(2000);
                firstEnd = firstStart + _gridRows.RowCount / 6;
                FilterOutDataGrid(sender, receiver, attribute, code, firstStart, firstEnd);
                readFilterFac2 = null;
            }, readFilterToken2);

            CancellationToken readFilterToken3 = readFilterSource.Token;
            TaskFactory? readFilterFac3 = new(readFilterToken3);
            _ = readFilterFac3.StartNew(() => {
                Thread.Sleep(3000);
                firstStart = firstEnd + _gridRows.RowCount / 6;
                FilterOutDataGrid(sender, receiver, attribute, code, firstEnd, firstStart);
                readFilterFac3 = null;
            }, readFilterToken3);

            CancellationToken readFilterToken4 = readFilterSource.Token;
            TaskFactory? readFilterFac4 = new(readFilterToken4);
            _ = readFilterFac4.StartNew(() => {
                Thread.Sleep(4000);
                firstEnd = firstStart + _gridRows.RowCount / 6;
                FilterOutDataGrid(sender, receiver, attribute, code, firstStart, firstEnd);
                readFilterFac4 = null;
            }, readFilterToken4);

            CancellationToken readFilterToken5 = readFilterSource.Token;
            TaskFactory? readFilterFac5 = new(readFilterToken5);
            _ = readFilterFac5.StartNew(() => {
                Thread.Sleep(7000);
                firstStart = _gridRows.RowCount - 1;
                FilterOutDataGrid(sender, receiver, attribute, code, firstEnd, firstStart);
                _outputTextBox.Invoke(new Action(() => {
                    _outputTextBox.AppendText($"Finish.");
                    readFilterSource.Dispose();
                }));
                readFilterFac5 = null;
            }, readFilterToken5);
        }

        public void ReadFileHandling() {
            if(_path == null) return;
            readFileSource = new();

            FileStream fileStremRead = File.OpenRead(_path);
            long lenghtFile = fileStremRead.Length;
            long firstEnd = lenghtFile / 6, firstStart = 0;
            BinaryReader readerFile = new(fileStremRead);
            char[] allChars = readerFile.ReadChars((int)lenghtFile);
            readerFile.Close();
            fileStremRead.Close();

            CancellationToken readFileToken = readFileSource.Token;
            TaskFactory? readFileFac = new(readFileToken);
            _ = readFileFac.StartNew(() => {
                while(firstEnd < allChars.Length && allChars[firstEnd] != '\n') firstEnd++;
                ReadFileFactory(allChars, firstStart, firstEnd);
                readFileFac = null;
            }, readFileToken);

            CancellationToken readFileToken1 = readFileSource.Token;
            TaskFactory? readFileFac1 = new(readFileToken1);
            _ = readFileFac1.StartNew(() => {
                Thread.Sleep(1000);
                firstEnd++;
                firstStart = firstEnd + lenghtFile / 6;
                while(firstStart < allChars.Length && allChars[firstStart] != '\n') firstStart++;
                ReadFileFactory(allChars, firstEnd, firstStart);
                readFileFac1 = null;
            }, readFileToken1);

            CancellationToken readFileToken2 = readFileSource.Token;
            TaskFactory? readFileFac2 = new(readFileToken2);
            _ = readFileFac2.StartNew(() => {
                Thread.Sleep(2000);
                firstStart++;
                firstEnd = firstStart + lenghtFile / 6;
                while(firstEnd < allChars.Length && allChars[firstEnd] != '\n') firstEnd++;
                ReadFileFactory(allChars, firstStart, firstEnd);
                readFileFac2 = null;
            }, readFileToken2);

            CancellationToken readFileToken3 = readFileSource.Token;
            TaskFactory? readFileFac3 = new(readFileToken3);
            _ = readFileFac3.StartNew(() => {
                Thread.Sleep(3000);
                firstEnd++;
                firstStart = firstEnd + lenghtFile / 6;
                while(firstStart < allChars.Length && allChars[firstStart] != '\n') firstStart++;
                ReadFileFactory(allChars, firstEnd, firstStart);
                readFileFac3 = null;
            }, readFileToken3);

            CancellationToken readFileToken4 = readFileSource.Token;
            TaskFactory? readFileFac4 = new(readFileToken4);
            _ = readFileFac4.StartNew(() => {
                Thread.Sleep(4000);
                firstStart++;
                firstEnd = firstStart + lenghtFile / 6;
                while(firstEnd < allChars.Length && allChars[firstEnd] != '\n') firstEnd++;
                ReadFileFactory(allChars, firstStart, firstEnd);
                readFileFac4 = null;
            }, readFileToken4);

            CancellationToken readFileToken5 = readFileSource.Token;
            TaskFactory? readFileFac5 = new(readFileToken5);
            _ = readFileFac5.StartNew(() => {
                Thread.Sleep(5000);
                firstEnd++;
                firstStart = lenghtFile;
                while(firstStart < allChars.Length && allChars[firstStart] != '\n') firstStart++;
                ReadFileFactory(allChars, firstEnd, firstStart);
                _outputTextBox.Invoke(new Action(() => {
                    _outputTextBox.AppendText($"Finish. Rows = {_gridRows.RowCount}");
                    readFileSource.Dispose();
                }));
                readFileFac5 = null;
            }, readFileToken5);
        }

        private void ReadFileFactory(char[] allChars, long startIndex, long endIndex) {
            if(endIndex > allChars.Length) endIndex = allChars.Length;

            int countRows = 0;
            string result = "";
            while(startIndex < endIndex) {
                if(readFileSource.IsCancellationRequested) { break; }
                bool stringReading = false;
                while(true) {
                    if(ReadString(allChars[startIndex], ref result)) {
                        _gridRows.Invoke(new Action(() => {
                            SP.ParsePassedString(result.Remove(result.Length - 1, 1), _gridRows.Rows);
                            dataTable.Rows.Add(_gridRows.Rows[countRows].Cells[0].Value, _gridRows.Rows[countRows].Cells[1].Value,
                                _gridRows.Rows[countRows].Cells[2].Value, _gridRows.Rows[countRows].Cells[3].Value,
                                _gridRows.Rows[countRows].Cells[4].Value, _gridRows.Rows[countRows].Cells[5].Value,
                                _gridRows.Rows[countRows].Cells[6].Value, _gridRows.Rows[countRows].Cells[7].Value);
                            if(!_filterSender.Items.Contains(_gridRows.Rows[countRows].Cells[3].Value))
                                _filterSender.Items.Add(_gridRows.Rows[countRows].Cells[3].Value);
                            if(!_filterReceiver.Items.Contains(_gridRows.Rows[countRows].Cells[4].Value))
                                _filterReceiver.Items.Add(_gridRows.Rows[countRows].Cells[4].Value);
                            if(!_filterAttribute.Items.Contains(_gridRows.Rows[countRows].Cells[5].Value))
                                _filterAttribute.Items.Add(_gridRows.Rows[countRows].Cells[5].Value);
                            if(!_filterCode.Items.Contains(_gridRows.Rows[countRows].Cells[6].Value))
                                _filterCode.Items.Add(_gridRows.Rows[countRows].Cells[6].Value);
                        }));
                        countRows++;
                        result = "";
                        stringReading = true;
                    }
                    startIndex++;
                    if(stringReading) break;
                }
            }
        }

        private void FilterOutDataGrid(string sender, string receiver, string attribute, string code,
                int startIndex, int endIndex) {
            if(endIndex > _gridRows.RowCount - 1) endIndex = _gridRows.RowCount - 1;

            while(startIndex < endIndex) {
                if(readFilterSource.IsCancellationRequested) { break; }
                _gridRows.Invoke(new Action(() => {
                    if(CheckRow(sender, receiver, attribute, code, startIndex))
                        _filterGridRows.Rows.Add(dataTable.Rows[startIndex].ItemArray);
                }));
                startIndex++;
            }
        }

        private bool CheckRow(string sender, string receiver, string attribute, string code,
                int index) {
            if(sender.Length == 0 && receiver.Length == 0 &&
                attribute.Length == 0 && code.Length == 0) return false;
            bool check = true;

            string[] allCheck = new string[4] { sender, receiver, attribute, code };
            List<bool> boolCheck = new();
            for(int i = 0; i < 4; i++) {
                if(allCheck[i].Length > 0)
                    if(allCheck[i] == _gridRows.Rows[index].Cells[i + 3].Value.ToString())
                        boolCheck.Add(true);
                    else
                        boolCheck.Add(false);
            }
            for(int i = 0; i < boolCheck.Count; i++) {
                if(!boolCheck[i]) {
                    check = false;
                    break;
                }
            }

            return check;
        }
    }
}