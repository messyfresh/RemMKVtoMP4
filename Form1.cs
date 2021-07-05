using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFmpeg.NET;
using FFmpeg.NET.Events;

namespace RemMKVtoMP4
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void mkvFileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openMKVFileDialog = new OpenFileDialog
			{
				InitialDirectory = @"%USERPROFILE%\Videos",
				Title = "Select MKV File",

				CheckFileExists = true,
				CheckPathExists = true,

				DefaultExt = "mkv",
				Filter = "mkv files (*.mkv)|*.mkv",
				FilterIndex = 2,
				RestoreDirectory = true
			};

			if (openMKVFileDialog.ShowDialog() == DialogResult.OK)
			{
				mkvFileLabel.Text = openMKVFileDialog.FileName;
			}
		}

		private void mp4FileButton_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveMP4FileDialog = new SaveFileDialog
			{
				InitialDirectory = @"%USERPROFILE%\Videos",
				Title = "Save MP4 File",

				CheckFileExists = false,
				CheckPathExists = true,

				DefaultExt = "mp4",
				Filter = "mp4 files (*.mp4)|*.mp4",
				FilterIndex = 2,
				RestoreDirectory = true
			};

			if (saveMP4FileDialog.ShowDialog() == DialogResult.OK)
			{
				mp4FileLabel.Text = saveMP4FileDialog.FileName;
			}
		}

		private async void convertButton_Click(object sender, EventArgs e)
		{
			await StartConversion();
		}

		public async Task StartConversion()
		{
			var ffmpeg = new Engine("C:\\FFMPEG\\bin\\ffmpeg.exe");
			var inputMKV = new InputFile(@mkvFileLabel.Text.ToString());
			var outputMP4 = new OutputFile(@mp4FileLabel.Text.ToString());

			ffmpeg.Progress += OnProgress;
			ffmpeg.Data += OnData;
			ffmpeg.Error += OnError;
			ffmpeg.Complete += OnComplete;

			conversionProgressBar.Style = ProgressBarStyle.Marquee;
			conversionProgressBar.MarqueeAnimationSpeed = 30;
			await ffmpeg.ConvertAsync(inputMKV, outputMP4);
			conversionProgressBar.MarqueeAnimationSpeed = 0;
			conversionProgressBar.Style = ProgressBarStyle.Blocks;
			conversionProgressBar.Value = 0;
			string doneMessage = "Done";
			MessageBox.Show(doneMessage);
		}

		private void OnProgress(object sender, ConversionProgressEventArgs e)
		{
			Debug.WriteLine("[{0} => {1}]", e.Input.Name, e.Output.Name);
			Debug.WriteLine("Bitrate: {0}", e.Bitrate);
			Debug.WriteLine("Fps: {0}", e.Fps);
			Debug.WriteLine("Frame: {0}", e.Frame);
			Debug.WriteLine("ProcessedDuration: {0}", e.ProcessedDuration);
			Debug.WriteLine("Size: {0} kb", e.SizeKb);
			Debug.WriteLine("TotalDuration: {0}\n", e.TotalDuration);

		}

		private void OnData(object sender, ConversionDataEventArgs e)
		{
			Debug.WriteLine("[{0} => {1}]: {2}", e.Input.Name, e.Output.Name, e.Data);
		}

		private void OnComplete(object sender, ConversionCompleteEventArgs e)
		{
			Debug.WriteLine("Completed conversion from {0} to {1}", e.Input.Name, e.Output.Name);
		}

		private void OnError(object sender, ConversionErrorEventArgs e)
		{
			Debug.WriteLine("[{0} => {1}]: Error: {2}\n{3}", e.Input.Name, e.Output.Name, e.Exception.ExitCode, e.Exception.InnerException);
		}
	}
}
