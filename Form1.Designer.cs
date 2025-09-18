namespace CRUD
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtLocalizar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            listView = new ListView();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(50, 289);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 0;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(699, 52);
            button2.Name = "button2";
            button2.Size = new Size(89, 42);
            button2.TabIndex = 1;
            button2.Text = "Consultar";
            button2.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(50, 74);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(193, 23);
            txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(50, 165);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 245);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(193, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(378, 63);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(296, 23);
            txtLocalizar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 39);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 136);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 227);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 39);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 9;
            label4.Text = "Localizar:";
            // 
            // listView
            // 
            listView.Location = new Point(378, 136);
            listView.Name = "listView";
            listView.Size = new Size(378, 281);
            listView.TabIndex = 10;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(50, 356);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 11;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(listView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLocalizar);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtLocalizar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listView;
        private Button button3;
    }
}
