using System;
using System.Data.SqlTypes;

namespace SergeyParcesr {
    internal class FileHandling {
        private readonly StringParsing SP = new();
        private CancellationTokenSource readFileSource, readFilterSource;

        private readonly string _path;
        private readonly RichTextBox _outputTextBox;
        private readonly DataGridView _gridRows;
        private readonly ComboBox _filterSender, _filterReceiver, _filterAttribute, _filterCode;
        public FileHandling(string path, RichTextBox outputTextBox, DataGridView gridRows,
                ComboBox filterSender, ComboBox filterReceiver, ComboBox filterAttribute, ComboBox filterCode) {
            _path = path;
            _outputTextBox = outputTextBox;
            _gridRows = gridRows;
            readFileSource = new();
            readFilterSource = new();
            _filterSender = filterSender;
            _filterReceiver = filterReceiver;
            _filterAttribute = filterAttribute;
            _filterCode = filterCode;
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
                Thread.Sleep(5000);
                firstStart = firstEnd + _gridRows.RowCount;
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
            int firstEnd = 1000000, firstStart = 0;

            FileStream fileStremRead = File.OpenRead(_path);
            BinaryReader readerFile = new(fileStremRead);
            char[] allChars = readerFile.ReadChars((int)fileStremRead.Length);
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
                firstStart = firstEnd * 2;
                while(firstStart < allChars.Length && allChars[firstStart] != '\n') firstStart++;
                ReadFileFactory(allChars, firstEnd, firstStart);
                readFileFac1 = null;
            }, readFileToken1);

            CancellationToken readFileToken2 = readFileSource.Token;
            TaskFactory? readFileFac2 = new(readFileToken2);
            _ = readFileFac2.StartNew(() => {
                Thread.Sleep(2000);
                firstStart++;
                firstEnd = firstStart * 2;
                while(firstEnd < allChars.Length && allChars[firstEnd] != '\n') firstEnd++;
                ReadFileFactory(allChars, firstStart, firstEnd);
                readFileFac2 = null;
            }, readFileToken2);

            CancellationToken readFileToken3 = readFileSource.Token;
            TaskFactory? readFileFac3 = new(readFileToken3);
            _ = readFileFac3.StartNew(() => {
                Thread.Sleep(3000);
                firstEnd++;
                firstStart = firstEnd * 2;
                while(firstStart < allChars.Length && allChars[firstStart] != '\n') firstStart++;
                ReadFileFactory(allChars, firstEnd, firstStart);
                readFileFac3 = null;
            }, readFileToken3);

            CancellationToken readFileToken4 = readFileSource.Token;
            TaskFactory? readFileFac4 = new(readFileToken4);
            _ = readFileFac4.StartNew(() => {
                Thread.Sleep(4000);
                firstStart++;
                firstEnd = firstStart * 2;
                while(firstEnd < allChars.Length && allChars[firstEnd] != '\n') firstEnd++;
                ReadFileFactory(allChars, firstStart, firstEnd);
                readFileFac4 = null;
            }, readFileToken4);

            CancellationToken readFileToken5 = readFileSource.Token;
            TaskFactory? readFileFac5 = new(readFileToken5);
            _ = readFileFac5.StartNew(() => {
                Thread.Sleep(5000);
                firstEnd++;
                firstStart = firstEnd * 2;
                while(firstStart < allChars.Length && allChars[firstStart] != '\n') firstStart++;
                ReadFileFactory(allChars, firstEnd, firstStart);
                _outputTextBox.Invoke(new Action(() => {
                    _outputTextBox.AppendText($"Finish. Rows = {_gridRows.RowCount}");
                    readFileSource.Dispose();
                }));
                readFileFac5 = null;
            }, readFileToken5);
        }

        private void ReadFileFactory(char[] allChars, int startIndex, int endIndex) {
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
                    if(sender.Length > 0 &&
                        sender != _gridRows.Rows[startIndex].Cells[3].Value.ToString()) {
                        _gridRows.Rows[startIndex].Visible = false;
                    } else if(receiver.Length > 0 &&
                            receiver != _gridRows.Rows[startIndex].Cells[4].Value.ToString()) {
                        _gridRows.Rows[startIndex].Visible = false;
                    } else if(attribute.Length > 0 &&
                            attribute != _gridRows.Rows[startIndex].Cells[5].Value.ToString()) {
                        _gridRows.Rows[startIndex].Visible = false;
                    } else if(code.Length > 0 &&
                            code != _gridRows.Rows[startIndex].Cells[6].Value.ToString()) {
                        _gridRows.Rows[startIndex].Visible = false;
                    } else if(!_gridRows.Rows[startIndex].Visible) {
                        _gridRows.Rows[startIndex].Visible = true;
                    }
                }));
                startIndex++;
            }
        }
    }
}