using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{
    class SaveLog
    {
        public SaveLog(DUTSample testSample ,string logFileName)
		{
			string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

			try
			{
				// Creating System.IO.FileStream object
                using (FileStream filestream = new FileStream(Properties.Settings.Default.savedLogFileLocation + "\\" + logFileName, FileMode.Create, FileAccess.Write, FileShare.None))
				// Creating iTextSharp.text.Document object
                using (Document document = new Document(iTextSharp.text.PageSize.A4.Rotate(), 25, 25, 30, 30)) 

				// Creating iTextSharp.text.pdf.PdfWriter object
				// It helps to write the Document to the Specified FileStream
				using (PdfWriter pdfWriter = PdfWriter.GetInstance(document, filestream))
				{
					// Setting Viewer Preferences by calling method
					pdfWriter.AddViewerPreference(PdfName.HIDEMENUBAR, new PdfBoolean(true));

					// Setting View Preferences by setting properties
					pdfWriter.ViewerPreferences = PdfWriter.HideMenubar;

                    document.AddAuthor("Author");
                    document.AddCreator("Creator");
                    document.AddKeywords("Keywords");
                    document.AddSubject("Document subject");
                    document.AddTitle("The document title");

					// Openning the Document
					document.Open();

                    PdfContentByte pdfContentByte = pdfWriter.DirectContent;
                    BaseFont baseFont = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

					document.NewPage();

                    pdfContentByte.BeginText();
                    pdfContentByte.SetFontAndSize(baseFont, 15);
                    pdfContentByte.SetTextMatrix(380, 540);
                    pdfContentByte.ShowText("ES Lab Report");
                    pdfContentByte.EndText();

                    pdfContentByte.BeginText();
                    pdfContentByte.SetFontAndSize(baseFont, 24);
                    pdfContentByte.SetTextMatrix(230, 440);
                    pdfContentByte.ShowText("ES Lab Continuous Monitoring System Report");
                    pdfContentByte.EndText();

                    iTextSharp.text.Image imglogo = iTextSharp.text.Image.GetInstance(appRootDir + "/Resources/" + "logo.png");
                    imglogo.SetAbsolutePosition(40, 470);
                    imglogo.ScalePercent(65f);
                    pdfContentByte.AddImage(imglogo);

                    PdfPTable pdfTable = new PdfPTable(2);
                    PdfPCell pdfCell = new PdfPCell();
                    pdfCell.Colspan = 2;
                    pdfCell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    pdfTable.SpacingBefore = 50f;
                    pdfTable.SpacingAfter = 30f;
                    pdfTable.TotalWidth = 750f;
                    pdfTable.AddCell(pdfCell);
                    pdfTable.AddCell("Test ID");
                    pdfTable.AddCell(testSample.TestID);
                    pdfTable.AddCell("Test Name");
                    pdfTable.AddCell(testSample.TestType);
                    pdfTable.AddCell("Part Number");
                    pdfTable.AddCell(testSample.PartNumber);
                    pdfTable.AddCell("Customer");
                    pdfTable.AddCell(testSample.Customer);
                    pdfTable.AddCell("Channel No");
                    pdfTable.AddCell(testSample.ChNumber);
                    pdfTable.AddCell("Upper Test Limit (mA)");
                    pdfTable.AddCell(testSample.UpperTestLimit.ToString());
                    pdfTable.AddCell("Lower Test Limit (mA)");
                    pdfTable.AddCell(testSample.LowerTestLimit.ToString());
                    pdfTable.AddCell("Overall test result");
                    pdfTable.AddCell(testSample.TestResult);
                    pdfTable.AddCell("Start Time");
                    pdfTable.AddCell(Properties.Settings.Default.savedTestStartTime);
                    pdfTable.AddCell("End Time");
                    pdfTable.AddCell(Properties.Settings.Default.savedTestFinishedTime);
                    pdfTable.AddCell("Measurement instrument");
                    pdfTable.AddCell(Properties.Settings.Default.savedInstrumentName);
                    pdfTable.AddCell("Measurement instrument serial");
                    pdfTable.AddCell(Properties.Settings.Default.savedInstrumentSerial);
                    pdfTable.AddCell("Climatic chamber name");
                    pdfTable.AddCell(Properties.Settings.Default.savedChamberName);
                    pdfTable.AddCell("Climatic chamber serial");
                    pdfTable.AddCell(Properties.Settings.Default.savedChamberSerial);
                    pdfTable.AddCell("Climatic chamber program file path");
                    pdfTable.AddCell(Properties.Settings.Default.savedChamberProgramFilePath + Properties.Settings.Default.savedChamberProgramFileName);
                    pdfTable.AddCell("Climatic chamber archive file path");
                    pdfTable.AddCell(Properties.Settings.Default.savedChamberArchiveFilePath + Properties.Settings.Default.savedChamberArchiveFileName);

                    pdfTable.WriteSelectedRows(0, -1, 50, 400, pdfContentByte);

					document.NewPage();

                    pdfContentByte.BeginText();
                    pdfContentByte.SetFontAndSize(baseFont, 15);
                    pdfContentByte.SetTextMatrix(380, 540);
                    pdfContentByte.ShowText("ES Lab Report");
                    pdfContentByte.EndText();

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Settings.Default.savedLogFileLocation + "\\" + "chart" + testSample.ChNumber + ".png");
                    img.SetAbsolutePosition(150, 100);
                    img.ScalePercent(85f);
                    pdfContentByte.AddImage(img);

					// Closing the Document
					document.Close();
				}
			}
			// Catching iTextSharp.text.DocumentException if any
			catch (DocumentException de)
			{
				throw de;
			}
			// Catching System.IO.IOException if any
			catch (IOException ioe)
			{
				throw ioe;
			}
		}
    }
}
