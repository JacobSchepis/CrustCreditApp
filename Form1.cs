using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrustCreditApp
{
    public partial class CreditSystem : Form
    {
        public CreditSystem()
        {
            InitializeComponent();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = tabControl.SelectedIndex;

            if (selectedIndex == 1)
                PopulateDataGrid(CreditStore.CreditEntries);
        }

        private void PopulateDataGrid(List<CreditEntry> creditEntries)
        {
            dataGridCredits.Rows.Clear();

            var sorted = creditEntries
                .OrderByDescending(entry => entry.DateAdded)
                .ToList();

            foreach (var creditEntry in sorted)
            {
                var name = creditEntry.CustomerName;
                var phone = creditEntry.PhoneNumber;
                var credit = creditEntry.CreditAmount;
                var dateAdded = creditEntry.DateAdded;
                var dateRedeemed = creditEntry.DateRedeemed;
                var comments = creditEntry.Comments;

                string dateRedeemedString = (dateRedeemed == DateTime.MinValue) ? "" : dateRedeemed.ToShortDateString();

                dataGridCredits.Rows.Add(
                    phone,
                    name,
                    credit,
                    dateAdded.ToShortDateString(),
                    dateRedeemedString,
                    comments,
                    creditEntry
                    );
            }
        }

        private void Tab1EntryButton_MouseClick(object sender, MouseEventArgs e)
        {
            var newEntry = new CreditEntry()
            {
                CustomerName = Tab1NameInput.Text.Trim(),
                PhoneNumber = Tab1PhoneInput.Text,
                CreditAmount = decimal.TryParse(Tab1CreditInput.Text, out var amt) ? amt : 0,
                DateAdded = DateTime.Now,
                DateRedeemed = DateTime.MinValue,
                Comments = Tab1CommentInput.Text.Trim(),
            };

            CreditStore.CreditEntries.Add(newEntry);
        }

        private void CreditSystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            CreditStore.SaveCredits();
        }

        private void CreditSystem_Load(object sender, EventArgs e)
        {
            CreditStore.LoadCredits();
        }

        private void Tab2PhoneInput_TextChanged(object sender, EventArgs e)
        {
            var query = Tab2PhoneInput.Text;

            var creditEntries = CreditStore.CreditEntries
                .Where(x => x.PhoneNumber.Contains(query))
                .ToList();

            PopulateDataGrid(creditEntries);
        }

        private void Tab2NameInput_TextChanged(object sender, EventArgs e)
        {
            var query = Tab2NameInput.Text;

            var creditEntries = CreditStore.CreditEntries
                .Where(x => x.CustomerName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            PopulateDataGrid(creditEntries);
        }

        private void dataGridCredits_DoubleClick(object sender, EventArgs e)
        {

        }


        private void Tab1PhoneInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Tab1CreditInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;

            // Allow control keys (Backspace, Delete, etc.)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
            {
                // If a decimal exists, ensure max 2 digits after it
                int dotIndex = tb.Text.IndexOf('.');
                if (dotIndex >= 0 && tb.SelectionStart > dotIndex)
                {
                    int decimalPlaces = tb.Text.Length - dotIndex - 1;
                    if (decimalPlaces >= 2)
                    {
                        e.Handled = true; // block if already 2 digits after dot
                        return;
                    }
                }

                return;
            }

            // Allow only one decimal point
            if (e.KeyChar == '.')
            {
                if (!tb.Text.Contains("."))
                    return;
            }

            // Block everything else
            e.Handled = true;
        }

        private string ShowCommentEditor(string original)
        {
            Form form = new Form
            {
                Text = "View/Edit Comment",
                Width = 400,
                Height = 300,
                StartPosition = FormStartPosition.CenterParent
            };

            TextBox textBox = new TextBox
            {
                Multiline = true,
                Dock = DockStyle.Fill,
                Text = original,
                ScrollBars = ScrollBars.Vertical
            };

            Button okButton = new Button { Text = "OK", Dock = DockStyle.Bottom, DialogResult = DialogResult.OK };
            form.Controls.Add(textBox);
            form.Controls.Add(okButton);
            form.AcceptButton = okButton;

            return form.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        private void dataGridCredits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("Something cool");
        }

        private void Tab1PhoneInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
