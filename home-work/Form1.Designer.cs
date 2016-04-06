namespace home_work
{
	partial class Form1
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
			this.trainbutton = new System.Windows.Forms.Button();
			this.trainRMSE = new System.Windows.Forms.RichTextBox();
			this.selectdata = new System.Windows.Forms.Button();
			this.trainprogress = new System.Windows.Forms.TextBox();
			this.filename = new System.Windows.Forms.TextBox();
			this.testRMSE = new System.Windows.Forms.RichTextBox();
			this.testprogress = new System.Windows.Forms.TextBox();
			this.testbutton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.learningrate = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.hidelayers = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.hideneuroncount = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.trainingloop = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// trainbutton
			// 
			this.trainbutton.Location = new System.Drawing.Point(12, 283);
			this.trainbutton.Name = "trainbutton";
			this.trainbutton.Size = new System.Drawing.Size(75, 23);
			this.trainbutton.TabIndex = 1;
			this.trainbutton.Text = "開始訓練";
			this.trainbutton.UseVisualStyleBackColor = true;
			this.trainbutton.Click += new System.EventHandler(this.trainbutton_Click);
			// 
			// trainRMSE
			// 
			this.trainRMSE.Location = new System.Drawing.Point(282, 63);
			this.trainRMSE.Name = "trainRMSE";
			this.trainRMSE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.trainRMSE.Size = new System.Drawing.Size(233, 367);
			this.trainRMSE.TabIndex = 2;
			this.trainRMSE.Text = "";
			// 
			// selectdata
			// 
			this.selectdata.Location = new System.Drawing.Point(12, 32);
			this.selectdata.Name = "selectdata";
			this.selectdata.Size = new System.Drawing.Size(75, 23);
			this.selectdata.TabIndex = 3;
			this.selectdata.Text = "選擇資料集";
			this.selectdata.UseVisualStyleBackColor = true;
			this.selectdata.Click += new System.EventHandler(this.selectdata_Click);
			// 
			// trainprogress
			// 
			this.trainprogress.Location = new System.Drawing.Point(282, 32);
			this.trainprogress.Name = "trainprogress";
			this.trainprogress.ReadOnly = true;
			this.trainprogress.Size = new System.Drawing.Size(232, 22);
			this.trainprogress.TabIndex = 15;
			// 
			// filename
			// 
			this.filename.Location = new System.Drawing.Point(107, 32);
			this.filename.Name = "filename";
			this.filename.ReadOnly = true;
			this.filename.Size = new System.Drawing.Size(151, 22);
			this.filename.TabIndex = 17;
			// 
			// testRMSE
			// 
			this.testRMSE.Location = new System.Drawing.Point(529, 63);
			this.testRMSE.Name = "testRMSE";
			this.testRMSE.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.testRMSE.Size = new System.Drawing.Size(232, 367);
			this.testRMSE.TabIndex = 18;
			this.testRMSE.Text = "";
			// 
			// testprogress
			// 
			this.testprogress.Location = new System.Drawing.Point(529, 32);
			this.testprogress.Name = "testprogress";
			this.testprogress.ReadOnly = true;
			this.testprogress.Size = new System.Drawing.Size(232, 22);
			this.testprogress.TabIndex = 19;
			// 
			// testbutton
			// 
			this.testbutton.Location = new System.Drawing.Point(107, 283);
			this.testbutton.Name = "testbutton";
			this.testbutton.Size = new System.Drawing.Size(75, 23);
			this.testbutton.TabIndex = 20;
			this.testbutton.Text = "開始測試";
			this.testbutton.UseVisualStyleBackColor = true;
			this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(280, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 21;
			this.label1.Text = "訓練結果";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(527, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 22;
			this.label2.Text = "測試結果";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(46, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 23;
			this.label3.Text = "學習率";
			// 
			// learningrate
			// 
			this.learningrate.Location = new System.Drawing.Point(107, 104);
			this.learningrate.Name = "learningrate";
			this.learningrate.Size = new System.Drawing.Size(151, 22);
			this.learningrate.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 25;
			this.label4.Text = "隱藏層層數";
			// 
			// hidelayers
			// 
			this.hidelayers.Location = new System.Drawing.Point(107, 137);
			this.hidelayers.Name = "hidelayers";
			this.hidelayers.Size = new System.Drawing.Size(151, 22);
			this.hidelayers.TabIndex = 26;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 12);
			this.label5.TabIndex = 27;
			this.label5.Text = "隱藏層神經元數";
			// 
			// hideneuroncount
			// 
			this.hideneuroncount.Location = new System.Drawing.Point(107, 171);
			this.hideneuroncount.Name = "hideneuroncount";
			this.hideneuroncount.Size = new System.Drawing.Size(151, 22);
			this.hideneuroncount.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(53, 12);
			this.label6.TabIndex = 29;
			this.label6.Text = "訓練次數";
			// 
			// trainingloop
			// 
			this.trainingloop.Location = new System.Drawing.Point(107, 208);
			this.trainingloop.Name = "trainingloop";
			this.trainingloop.Size = new System.Drawing.Size(151, 22);
			this.trainingloop.TabIndex = 30;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Location = new System.Drawing.Point(4, 75);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 177);
			this.groupBox1.TabIndex = 31;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "參數設定";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 442);
			this.Controls.Add(this.trainingloop);
			this.Controls.Add(this.hideneuroncount);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.hidelayers);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.learningrate);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.testbutton);
			this.Controls.Add(this.testprogress);
			this.Controls.Add(this.testRMSE);
			this.Controls.Add(this.trainprogress);
			this.Controls.Add(this.filename);
			this.Controls.Add(this.selectdata);
			this.Controls.Add(this.trainRMSE);
			this.Controls.Add(this.trainbutton);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button trainbutton;
		private System.Windows.Forms.RichTextBox trainRMSE;
		private System.Windows.Forms.Button selectdata;
		private System.Windows.Forms.TextBox trainprogress;
		private System.Windows.Forms.TextBox filename;
		private System.Windows.Forms.RichTextBox testRMSE;
		private System.Windows.Forms.TextBox testprogress;
		private System.Windows.Forms.Button testbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox learningrate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox hidelayers;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox hideneuroncount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox trainingloop;
		private System.Windows.Forms.GroupBox groupBox1;


	}
}

