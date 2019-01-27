using MuseumLog.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MuseumLog
{
    public partial class MuseumForm : Form
    {
        public MuseumForm()
        {
            InitializeComponent();
        }
        private void MuseumForm_Load(object sender, EventArgs e)
        {
            Int64 ID = Settings.Default.tempVisitorID;
            tempVisitorID.Text = ID.ToString();
           
            DateTime dateTday = DateTime.Today.Date;
            dateToday.Text = dateTday.ToString("dd/MM/yyyy");
            if ((int)dateTday.DayOfWeek == 0 || (int)dateTday.DayOfWeek == 6)
            {
                groupBox2.Text = "Start Page";
                resultText.Text = "Museum is closed";
                resultText.Show();
                newEntryBtn.Enabled = false;
                reportBtn.Enabled = false;
                searchBtn.Enabled = false;
            }
            else
            {
                groupBox2.Text = "Start Page";
                resultText.Text = "Museum Visitor Log";
                resultText.Show();
            }
        }

        private void NewEntryBtn_Click(object sender, EventArgs e)
        {
            long ID = Int64.Parse(tempVisitorID.Text);
            visitorID.Text = (ID + 1).ToString();
            tempVisitorID.Text = visitorID.Text;
            ResetEntryForm();
            resultText.Hide();
            reportPanel.Hide();
            newEntryPanel.Show();
            groupBox2.Text = "New Entry";

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            groupBox2.Text = "Search Result";
            reportPanel.Hide();
            newEntryPanel.Hide();
            string searchValue = searchBox.Text;
            if (MuseumLog.Validate.ValidateEmailFormat(searchValue))
            {
                SearchInFile(searchValue);
            }
            else
            {
                resultText.Text = "Visitor Not Found";
                resultText.Show();
            }
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            resultText.Hide();
            newEntryPanel.Hide();
            groupBox2.Text = "Report Section";
            reportPanel.Show();
        }

        private void DailyListBtn_Click(object sender, EventArgs e)
        {
            List<VisitorInfo> list = new List<VisitorInfo>();

            using (Stream stream = new FileStream("FinalVisitorInformation.csv", FileMode.Open, FileAccess.Read))
            {
                TextFileIO<VisitorInfo> cs = new TextFileIO<VisitorInfo>()
                {
                    UseTextQualifier = true,
                };
                list = cs.ReadFromFile(stream);
            }

            var date = reportDatePicker.Value.Date.ToString("dd/MM/yyyy");
            List<VisitorInfo> filteredList = new List<VisitorInfo>();
            foreach (VisitorInfo v in list)
            {
                if (v.EntryDate.Equals(date))
                {
                    DateTime outTime = DateTime.Parse(v.OutTime);
                    DateTime inTime = DateTime.Parse(v.InTime);
                    TimeSpan diff = (outTime - inTime);
                    v.TotalTime = Math.Round(diff.TotalMinutes, 2);
                    v.Day = reportDatePicker.Value.DayOfWeek.ToString();
                    filteredList.Add(v);
                }
            }

            MuseumLog.Sort sort = new MuseumLog.Sort();
            filteredList = sort.QuickSortByInTime(filteredList);

            BindingList<VisitorInfo> bindingList = new BindingList<VisitorInfo>(filteredList);
            BindingSource source = new BindingSource(bindingList, null);
            reportGridView.DataSource = source;
            reportGridView.Show();
        }

        private void WeeklyReportBtn_Click(object sender, EventArgs e)
        {
            List<VisitorInfo> list = new List<VisitorInfo>();

            using (Stream stream = new FileStream("FinalVisitorInformation.csv", FileMode.Open, FileAccess.Read))
            {
                TextFileIO<VisitorInfo> cs = new TextFileIO<VisitorInfo>()
                {
                    UseTextQualifier = true,
                };
                list = cs.ReadFromFile(stream);
            }

            var dateFrom = weeklyDatePicker.Value.Date;
            int dayindex = (int)dateFrom.DayOfWeek;
            int diff = 5 - dayindex;
            var dateTo = dateFrom.AddDays(diff);


            List<VisitorInfo> filteredList = new List<VisitorInfo>();
            foreach (VisitorInfo v in list)
            {
                var date = DateTime.ParseExact(v.EntryDate, "dd/mm/yyyy", CultureInfo.InvariantCulture);

                if (date >= dateFrom && date <= dateTo)
                {
                    DateTime outTime = DateTime.Parse(v.OutTime);
                    DateTime inTime = DateTime.Parse(v.InTime);
                    TimeSpan diffT = (outTime - inTime);
                    v.TotalTime = Math.Round(diffT.TotalMinutes, 2);
                    v.Day = date.DayOfWeek.ToString();
                    filteredList.Add(v);
                }
            }

            List<WeeklyReport> weekReport = GetWeekReport(filteredList);
            MuseumLog.Sort sort = new MuseumLog.Sort();

            BindingList<WeeklyReport> bindingList = new BindingList<WeeklyReport>(sort.QuickSortByTotalVisitor(weekReport));
            BindingSource source = new BindingSource(bindingList, null);
            reportGridView.DataSource = source;
            reportGridView.Show();

        }

        private void DailyReportBtn_Click(object sender, EventArgs e)
        {
            List<VisitorInfo> list = new List<VisitorInfo>();

            using (Stream stream = new FileStream("FinalVisitorInformation.csv", FileMode.Open, FileAccess.Read))
            {
                TextFileIO<VisitorInfo> cs = new TextFileIO<VisitorInfo>()
                {
                    UseTextQualifier = true,
                };
                list = cs.ReadFromFile(stream);
            }

            var date = dailyDatePicker.Value.Date.ToString("dd/MM/yyyy");
            List<VisitorInfo> filteredList = new List<VisitorInfo>();
            foreach (VisitorInfo v in list)
            {
                if (v.EntryDate.Equals(date))
                {
                    DateTime outTime = DateTime.Parse(v.OutTime);
                    DateTime inTime = DateTime.Parse(v.InTime);
                    TimeSpan diff = (outTime - inTime);
                    v.TotalTime = Math.Round(diff.TotalMinutes, 2);
                    v.Day = inTime.DayOfWeek.ToString();
                    filteredList.Add(v);
                }
            }

            string day = dailyDatePicker.Value.DayOfWeek.ToString();
            List<WeeklyReport> weekReport = GetWeekReport(filteredList);
            List<WeeklyReport> finalWeeklyReport = new List<WeeklyReport>();
            finalWeeklyReport.Add(weekReport.Find(a => a.Day.Equals(day)));

            BindingList<WeeklyReport> bindingList = new BindingList<WeeklyReport>(finalWeeklyReport);
            BindingSource source = new BindingSource(bindingList, null);
            reportGridView.DataSource = source;
            reportGridView.Show();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ValidateAndSaveData();

        }

        private void CsvInput_Click(object sender, EventArgs e)
        {
            DialogResult result = csvOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                List<VisitorInfo> visitorList = new List<VisitorInfo>();
                using (var stream = new FileStream(csvOpenFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    var cs = new TextFileIO<VisitorInfo>()
                    {
                        UseTextQualifier = true
                    };

                    visitorList = cs.ReadFromFile(stream);
                    WriteInitialDataToFile(visitorList);
                }
            }
        }

        private void ValidateAndSaveData()
        {
            List<VisitorInfo> visitorList = new List<VisitorInfo>();
            VisitorInfo visitor = new VisitorInfo();
            bool errorOccured = false;

            visitor.ID = Int64.Parse(visitorID.Text);
            visitor.EntryDate = dateToday.Text;
            visitor.InTime = inTimePicker.Text;
            if (outTimepicker.Visible)
                visitor.OutTime = outTimepicker.Text;



            string fName = fNameInput.Text;
            if (MuseumLog.Validate.ValidateEmpty(fName))
            {
                errFName.Hide();
                visitor.FirstName = fName;
            }
            else
            {
                errorOccured = true;
                errFName.Show();
            }

            string lName = lNameInput.Text;
            if (MuseumLog.Validate.ValidateEmpty(lName))
            {
                errLName.Hide();
                visitor.LastName = lName;
            }
            else
            {
                errorOccured = true;
                errLName.Show();
            }

            string address = addrInput.Text;
            if (MuseumLog.Validate.ValidateEmpty(address))
            {
                errAddr.Hide();
                visitor.Address = address;
            }
            else
            {
                errorOccured = true;
                errAddr.Show();
            }

            string contact = contactInput.Text;
            if (MuseumLog.Validate.ValidateNumber(contact))
            {
                errContact.Hide();
                visitor.ContactNo = Int64.Parse(contact);
            }
            else
            {
                errorOccured = true;
                errContact.Show();
            }

            string mailAddress = emailInput.Text;
            if (MuseumLog.Validate.ValidateEmailFormat(mailAddress))
            {
                errTxtEmail.Hide();
                visitor.MailAddress = mailAddress;
            }
            else
            {
                errorOccured = true;
                errTxtEmail.Show();
            }

            string occupation = occuptnInput.Text;
            if (MuseumLog.Validate.ValidateEmpty(occupation))
            {
                errOccuptn.Hide();
                visitor.Occupation = occupation;
            }
            else
            {
                errorOccured = true;
                errOccuptn.Show();
            }

            if (errorOccured == false)
            {
                visitorList.Add(visitor);
                bool abc = outTimepicker.Visible;
                if (outTimepicker.Visible)
                    WriteFinalDataToFile(visitorList);
                else
                    WriteInitialDataToFile(visitorList);

                newEntryBtn.PerformClick();
            }

        }

        private void SearchInFile(string searchValue)
        {
            List<VisitorInfo> searchedData = new List<VisitorInfo>();

            if (File.Exists("VisitorInformation.csv"))
            {
                using (Stream stream = new FileStream("VisitorInformation.csv", FileMode.Open, FileAccess.Read))
                {
                    TextFileIO<VisitorInfo> cs = new TextFileIO<VisitorInfo>()
                    {
                        UseTextQualifier = true,
                    };

                    searchedData = cs.SearchInFile(stream, searchValue);
                }
            }
            else
            {
                resultText.Text = "Visitor Not Found";
                resultText.Show();

            }

            bool visitorFound = false;
            string dateTody = dateToday.Text;
            foreach (VisitorInfo v in searchedData)
            {
                var abc = v.EntryDate;
                if (v.EntryDate.Equals(dateTody))
                {
                    visitorFound = true;

                    visitorID.Text = v.ID.ToString();
                    fNameInput.Text = v.FirstName;
                    lNameInput.Text = v.LastName;
                    contactInput.Text = v.ContactNo.ToString();
                    addrInput.Text = v.Address;
                    occuptnInput.Text = v.Occupation;
                    emailInput.Text = v.MailAddress;
                    inTimePicker.Text = v.InTime;

                    fNameInput.Enabled = false;
                    lNameInput.Enabled = false;
                    contactInput.Enabled = false;
                    addrInput.Enabled = false;
                    emailInput.Enabled = false;
                    occuptnInput.Enabled = false;
                    inTimePicker.Enabled = false;

                    outTimelabel.Show();
                    outTimepicker.Show();
                    newEntryPanel.Show();
                    resultText.Hide();
                }
            }

            if (!visitorFound)
            {
                resultText.Text = "Visitor Not Found";
                resultText.Show();
            }
        }

        private void WriteInitialDataToFile(List<VisitorInfo> visitorList)
        {
            if (File.Exists("VisitorInformation.csv"))
            {
                using (Stream stream = new FileStream("VisitorInformation.csv", FileMode.Open, FileAccess.ReadWrite))
                {
                    var cs = new TextFileIO<VisitorInfo>()
                    {
                        UseTextQualifier = true
                    };
                    cs.AppendToFile(stream, visitorList, "VisitorInformation.csv");
                }
            }
            else
            {
                using (Stream stream = new FileStream("VisitorInformation.csv", FileMode.Create, FileAccess.Write))
                {
                    var cs = new TextFileIO<VisitorInfo>
                    {
                        UseTextQualifier = true
                    };

                    cs.WriteToFile(stream, visitorList);
                }
            }

        }

        private void WriteFinalDataToFile(List<VisitorInfo> visitorList)
        {
            if (File.Exists("FinalVisitorInformation.csv"))
            {
                using (Stream stream = new FileStream("FinalVisitorInformation.csv", FileMode.Open, FileAccess.ReadWrite))
                {
                    var cs = new TextFileIO<VisitorInfo>()
                    {
                        UseTextQualifier = true
                    };
                    cs.AppendToFile(stream, visitorList, "FinalVisitorInformation.csv");
                }
            }
            else
            {
                using (Stream stream = new FileStream("FinalVisitorInformation.csv", FileMode.Create, FileAccess.Write))
                {
                    var cs = new TextFileIO<VisitorInfo>
                    {
                        UseTextQualifier = true
                    };

                    cs.WriteToFile(stream, visitorList);
                }
            }
        }

        private List<WeeklyReport> GetWeekReport(List<VisitorInfo> list)
        {
            List<WeeklyReport> resultList = new List<WeeklyReport>();
            WeeklyReport monday = new WeeklyReport
            {
                Day = "Monday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            WeeklyReport tuesday = new WeeklyReport
            {
                Day = "Tuesday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            WeeklyReport wednesday = new WeeklyReport
            {
                Day = "Wednesday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            WeeklyReport thursday = new WeeklyReport
            {
                Day = "Thrusday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            WeeklyReport friday = new WeeklyReport
            {
                Day = "Friday",
                TotalVisitor = 0,
                TotalTimeSpent = 0
            };
            foreach (VisitorInfo i in list)
            {
                var date = DateTime.ParseExact(i.EntryDate, "dd/mm/yyyy", CultureInfo.InvariantCulture);
                int day = (int)date.DayOfWeek;

                switch (day)
                {
                    case 1:
                        monday.TotalVisitor++;
                        monday.TotalTimeSpent = monday.TotalTimeSpent + i.TotalTime;
                        break;
                    case 2:
                        tuesday.TotalVisitor++;
                        tuesday.TotalTimeSpent = tuesday.TotalTimeSpent + i.TotalTime;
                        break;
                    case 3:
                        wednesday.TotalVisitor++;
                        wednesday.TotalTimeSpent = wednesday.TotalTimeSpent + i.TotalTime;
                        break;
                    case 4:
                        thursday.TotalVisitor++;
                        thursday.TotalTimeSpent = thursday.TotalTimeSpent + i.TotalTime;
                        break;
                    case 5:
                        friday.TotalVisitor++;
                        friday.TotalTimeSpent = friday.TotalTimeSpent + i.TotalTime;
                        break;

                    default:
                        break;
                }
            }

            resultList.Add(monday);
            resultList.Add(tuesday);
            resultList.Add(wednesday);
            resultList.Add(friday);
            resultList.Add(thursday);
            return resultList;
        }

        private void ResetEntryForm()
        {
            fNameInput.Text = "";
            lNameInput.Text = "";
            contactInput.Text = "";
            addrInput.Text = "";
            occuptnInput.Text = "";
            emailInput.Text = "";
            inTimePicker.Text = "";
            outTimelabel.Hide();
            outTimepicker.Hide();

            fNameInput.Enabled = true;
            lNameInput.Enabled = true;
            contactInput.Enabled = true;
            addrInput.Enabled = true;
            emailInput.Enabled = true;
            occuptnInput.Enabled = true;
            inTimePicker.Enabled = true;
        }

        private void MuseumForm_Closed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.tempVisitorID = Int32.Parse(tempVisitorID.Text);
            Settings.Default.Save();
        }
    }
}
