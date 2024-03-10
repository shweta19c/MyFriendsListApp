namespace MyFriendsList
{
    partial class btn_sortDescending
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            txt_newFriend = new TextBox();
            btn_addFriend = new Button();
            label1 = new Label();
            btn_AddFive = new Button();
            btn_sortAscending = new Button();
            button2 = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(316, 424);
            listBox1.TabIndex = 0;
            // 
            // txt_newFriend
            // 
            txt_newFriend.Location = new Point(345, 21);
            txt_newFriend.Name = "txt_newFriend";
            txt_newFriend.Size = new Size(314, 27);
            txt_newFriend.TabIndex = 1;
            // 
            // btn_addFriend
            // 
            btn_addFriend.Location = new Point(345, 64);
            btn_addFriend.Name = "btn_addFriend";
            btn_addFriend.Size = new Size(171, 34);
            btn_addFriend.TabIndex = 2;
            btn_addFriend.Text = "Add Friends";
            btn_addFriend.UseVisualStyleBackColor = true;
            btn_addFriend.Click += btn_addFriend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(548, 68);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // btn_AddFive
            // 
            btn_AddFive.Location = new Point(345, 114);
            btn_AddFive.Name = "btn_AddFive";
            btn_AddFive.Size = new Size(171, 29);
            btn_AddFive.TabIndex = 4;
            btn_AddFive.Text = "Add 5 friends";
            btn_AddFive.UseVisualStyleBackColor = true;
            btn_AddFive.Click += btn_AddFive_Click;
            // 
            // btn_sortAscending
            // 
            btn_sortAscending.Location = new Point(357, 318);
            btn_sortAscending.Name = "btn_sortAscending";
            btn_sortAscending.Size = new Size(94, 29);
            btn_sortAscending.TabIndex = 5;
            btn_sortAscending.Text = "A -> Z";
            btn_sortAscending.UseVisualStyleBackColor = true;
            btn_sortAscending.Click += btn_sortAscending_Click;
            // 
            // button2
            // 
            button2.Location = new Point(470, 318);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Z -> A";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(579, 318);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 29);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_sortDescending
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clear);
            Controls.Add(button2);
            Controls.Add(btn_sortAscending);
            Controls.Add(btn_AddFive);
            Controls.Add(label1);
            Controls.Add(btn_addFriend);
            Controls.Add(txt_newFriend);
            Controls.Add(listBox1);
            Name = "btn_sortDescending";
            Text = "My Friends";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox txt_newFriend;
        private Button btn_addFriend;
        private Label label1;
        private Button btn_AddFive;
        private Button btn_sortAscending;
        private Button button2;
        private Button btn_clear;
    }
}
