using System;

namespace CrustCreditApp
{
    partial class CreditSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditSystem));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Tab1EntryButton = new System.Windows.Forms.Button();
            this.Tab1CommentInput = new System.Windows.Forms.TextBox();
            this.Tab1CreditInput = new System.Windows.Forms.TextBox();
            this.Tab1NameInput = new System.Windows.Forms.TextBox();
            this.Tab1CommentText = new System.Windows.Forms.TextBox();
            this.Tab1CreditText = new System.Windows.Forms.TextBox();
            this.Tab1NameText = new System.Windows.Forms.TextBox();
            this.Tab1PhoneText = new System.Windows.Forms.TextBox();
            this.Tab1PhoneInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tab2PhoneInput = new System.Windows.Forms.TextBox();
            this.Tab2NameText = new System.Windows.Forms.TextBox();
            this.Tab2NameInput = new System.Windows.Forms.TextBox();
            this.dataGridCredits = new System.Windows.Forms.DataGridView();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRedeemed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab2PhoneText = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredits)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.Tab1EntryButton);
            this.tabPage1.Controls.Add(this.Tab1CommentInput);
            this.tabPage1.Controls.Add(this.Tab1CreditInput);
            this.tabPage1.Controls.Add(this.Tab1NameInput);
            this.tabPage1.Controls.Add(this.Tab1PhoneInput);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Tab1EntryButton
            // 
            resources.ApplyResources(this.Tab1EntryButton, "Tab1EntryButton");
            this.Tab1EntryButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Tab1EntryButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Tab1EntryButton.FlatAppearance.BorderSize = 10;
            this.Tab1EntryButton.Name = "Tab1EntryButton";
            this.Tab1EntryButton.UseVisualStyleBackColor = false;
            this.Tab1EntryButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tab1EntryButton_MouseClick);
            // 
            // Tab1CommentInput
            // 
            resources.ApplyResources(this.Tab1CommentInput, "Tab1CommentInput");
            this.Tab1CommentInput.Name = "Tab1CommentInput";
            // 
            // Tab1CreditInput
            // 
            resources.ApplyResources(this.Tab1CreditInput, "Tab1CreditInput");
            this.Tab1CreditInput.Name = "Tab1CreditInput";
            this.Tab1CreditInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab1CreditInput_KeyPress);
            // 
            // Tab1NameInput
            // 
            resources.ApplyResources(this.Tab1NameInput, "Tab1NameInput");
            this.Tab1NameInput.Name = "Tab1NameInput";
            // 
            // Tab1CommentText
            // 
            resources.ApplyResources(this.Tab1CommentText, "Tab1CommentText");
            this.Tab1CommentText.Name = "Tab1CommentText";
            this.Tab1CommentText.ReadOnly = true;
            // 
            // Tab1CreditText
            // 
            resources.ApplyResources(this.Tab1CreditText, "Tab1CreditText");
            this.Tab1CreditText.Name = "Tab1CreditText";
            this.Tab1CreditText.ReadOnly = true;
            // 
            // Tab1NameText
            // 
            resources.ApplyResources(this.Tab1NameText, "Tab1NameText");
            this.Tab1NameText.Name = "Tab1NameText";
            this.Tab1NameText.ReadOnly = true;
            // 
            // Tab1PhoneText
            // 
            resources.ApplyResources(this.Tab1PhoneText, "Tab1PhoneText");
            this.Tab1PhoneText.Name = "Tab1PhoneText";
            this.Tab1PhoneText.ReadOnly = true;
            // 
            // Tab1PhoneInput
            // 
            resources.ApplyResources(this.Tab1PhoneInput, "Tab1PhoneInput");
            this.Tab1PhoneInput.Name = "Tab1PhoneInput";
            this.Tab1PhoneInput.TextChanged += new System.EventHandler(this.Tab1PhoneInput_TextChanged);
            this.Tab1PhoneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab1PhoneInput_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Tab2PhoneInput);
            this.tabPage2.Controls.Add(this.Tab2NameText);
            this.tabPage2.Controls.Add(this.Tab2NameInput);
            this.tabPage2.Controls.Add(this.dataGridCredits);
            this.tabPage2.Controls.Add(this.Tab2PhoneText);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tab2PhoneInput
            // 
            resources.ApplyResources(this.Tab2PhoneInput, "Tab2PhoneInput");
            this.Tab2PhoneInput.Name = "Tab2PhoneInput";
            this.Tab2PhoneInput.TextChanged += new System.EventHandler(this.Tab2PhoneInput_TextChanged);
            // 
            // Tab2NameText
            // 
            resources.ApplyResources(this.Tab2NameText, "Tab2NameText");
            this.Tab2NameText.Name = "Tab2NameText";
            this.Tab2NameText.ReadOnly = true;
            // 
            // Tab2NameInput
            // 
            resources.ApplyResources(this.Tab2NameInput, "Tab2NameInput");
            this.Tab2NameInput.Name = "Tab2NameInput";
            this.Tab2NameInput.TextChanged += new System.EventHandler(this.Tab2NameInput_TextChanged);
            // 
            // dataGridCredits
            // 
            resources.ApplyResources(this.dataGridCredits, "dataGridCredits");
            this.dataGridCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCredits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneNumber,
            this.CustomerName,
            this.Credit,
            this.DateAdded,
            this.DateRedeemed,
            this.Comments,
            this.EntryObject});
            this.dataGridCredits.Name = "dataGridCredits";
            this.dataGridCredits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCredits_CellDoubleClick);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Frozen = true;
            resources.ApplyResources(this.PhoneNumber, "PhoneNumber");
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.Frozen = true;
            resources.ApplyResources(this.CustomerName, "CustomerName");
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.Frozen = true;
            resources.ApplyResources(this.Credit, "Credit");
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // DateAdded
            // 
            this.DateAdded.Frozen = true;
            resources.ApplyResources(this.DateAdded, "DateAdded");
            this.DateAdded.Name = "DateAdded";
            this.DateAdded.ReadOnly = true;
            // 
            // DateRedeemed
            // 
            this.DateRedeemed.Frozen = true;
            resources.ApplyResources(this.DateRedeemed, "DateRedeemed");
            this.DateRedeemed.Name = "DateRedeemed";
            this.DateRedeemed.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.Frozen = true;
            resources.ApplyResources(this.Comments, "Comments");
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            // 
            // EntryObject
            // 
            this.EntryObject.Frozen = true;
            resources.ApplyResources(this.EntryObject, "EntryObject");
            this.EntryObject.Name = "EntryObject";
            this.EntryObject.ReadOnly = true;
            // 
            // Tab2PhoneText
            // 
            resources.ApplyResources(this.Tab2PhoneText, "Tab2PhoneText");
            this.Tab2PhoneText.Name = "Tab2PhoneText";
            this.Tab2PhoneText.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Tab1CreditText);
            this.panel1.Controls.Add(this.Tab1PhoneText);
            this.panel1.Controls.Add(this.Tab1NameText);
            this.panel1.Controls.Add(this.Tab1CommentText);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // CreditSystem
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabControl);
            this.HelpButton = true;
            this.Name = "CreditSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreditSystem_FormClosing);
            this.Load += new System.EventHandler(this.CreditSystem_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCredits)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox Tab1PhoneText;
        private System.Windows.Forms.TextBox Tab1PhoneInput;
        private System.Windows.Forms.TextBox Tab1CommentInput;
        private System.Windows.Forms.TextBox Tab1CreditInput;
        private System.Windows.Forms.TextBox Tab1NameInput;
        private System.Windows.Forms.TextBox Tab1CommentText;
        private System.Windows.Forms.TextBox Tab1CreditText;
        private System.Windows.Forms.TextBox Tab1NameText;
        private System.Windows.Forms.Button Tab1EntryButton;
        private System.Windows.Forms.TextBox Tab2PhoneText;
        private System.Windows.Forms.DataGridView dataGridCredits;
        private System.Windows.Forms.TextBox Tab2PhoneInput;
        private System.Windows.Forms.TextBox Tab2NameText;
        private System.Windows.Forms.TextBox Tab2NameInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRedeemed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryObject;
        private System.Windows.Forms.Panel panel1;
    }
}

