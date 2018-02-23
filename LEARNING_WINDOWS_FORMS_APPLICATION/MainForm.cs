namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void insertButton_Click(object sender, System.EventArgs e)
		{
			// Solution (1)
			//fullNameslistBox.Items.Add(fullNameTextBox.Text);
			// /Solution (1)

			// Solution (2)
			//fullNameslistBox.Items.Add(fullNameTextBox.Text);

			//fullNameTextBox.Text = string.Empty;

			//fullNameTextBox.Focus();
			// /Solution (2)

			// Solution (3)
			fullNameslistBox.Items.Add(fullNameTextBox.Text);

			fullNameTextBox.Focus();

			fullNameTextBox.SelectAll();

			//fullNameTextBox.Select(start: 0, length: fullNameTextBox.Text.Length);

			//fullNameTextBox.SelectionStart = 0;
			//fullNameTextBox.SelectionLength = fullNameTextBox.Text.Length;
			// /Solution (3)
		}

		private void fullNameslistBox_KeyDown
			(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if ((e.Alt) || (e.Control) || (e.Shift))
			{
				return;
			}

			//// اگر کاربر دکمه دیلیت را زده بود
			//if (e.KeyCode == System.Windows.Forms.Keys.Delete)
			//{
			//	// و اگر آیتمی انتخاب شده بود
			//	if (fullNameslistBox.SelectedIndex >= 0)
			//	{
			//		// اندیس آیتم انتخاب شده را بدست آورده
			//		// و از لیست باکس آنرا حذف می‌کنیم
			//		fullNameslistBox.Items.RemoveAt(fullNameslistBox.SelectedIndex);
			//	}
			//}

			//// اگر کاربر دکمه دیلیت را زده بود
			//if (e.KeyCode == System.Windows.Forms.Keys.Delete)
			//{
			//	// و اگر آیتمی انتخاب شده بود
			//	if (fullNameslistBox.SelectedIndex >= 0)
			//	{
			//		// اندیس آیتم انتخاب شده را بدست آورده
			//		// و در متغیر کمکی ذخیره می‌کنیم
			//		int intSelectedIndex =
			//			fullNameslistBox.SelectedIndex;

			//		// با توجه به اندیس انتخاب شده
			//		// آیتمی با آن اندیس را لیست باکس حذف می‌کنیم
			//		fullNameslistBox.Items.RemoveAt(fullNameslistBox.SelectedIndex);

			//		// اندیس انتخاب شده لیست باکس را برابر اندیسی که قبلا
			//		// انتخاب شده بود قرار می‌دهیم
			//		// این بدان معنا است  که پس از حذف آیتم انتخاب شده
			//		// دقیقا آیتم بعدی آن انتخاب می‌شود
			//		fullNameslistBox.SelectedIndex = intSelectedIndex;
			//	}
			//}

			// اگر کاربر دکمه دیلیت را زده بود
			if (e.KeyCode == System.Windows.Forms.Keys.Delete)
			{
				// و اگر آیتمی انتخاب شده بود
				if (fullNameslistBox.SelectedIndex >= 0)
				{
					// اندیس آیتم انتخاب شده را بدست آورده
					// و در متغیر کمکی ذخیره می‌کنیم
					int intSelectedIndex =
						fullNameslistBox.SelectedIndex;

					// با توجه به اندیس انتخاب شده
					// آیتمی با آن اندیس را لیست باکس حذف می‌کنیم
					fullNameslistBox.Items.RemoveAt(fullNameslistBox.SelectedIndex);

					// اندیس انتخاب شده لیست باکس را برابر اندیسی که قبلا
					// انتخاب شده بود قرار می‌دهیم
					// این بدان معنا است  که پس از حذف آیتم انتخاب شده
					// دقیقا آیتم بعدی آن انتخاب می‌شود

					if (intSelectedIndex <= fullNameslistBox.Items.Count - 1)
					{
						fullNameslistBox.SelectedIndex = intSelectedIndex;
					}
					else
					{
						fullNameslistBox.SelectedIndex = fullNameslistBox.Items.Count - 1;
					}
				}
			}
		}

		private void fullNameslistBox_Enter(object sender, System.EventArgs e)
		{
			// اگر لااقل یک آیتم در داخل لیست باکس وجود داشت
			if (fullNameslistBox.Items.Count >= 1)
			{
				// و اگر هیچ آیتمی هنوز انتخاب نشده بود
				if (fullNameslistBox.SelectedIndex == -1)
				{
					// می خواهیم اولین آیتم لیست باکس انتخاب شود
					fullNameslistBox.SelectedIndex = 0;
				}
			}
		}
	}
}
