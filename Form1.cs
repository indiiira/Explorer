using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace FileCompression
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView tv1;
		private System.Windows.Forms.ListBox lstFiles;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblDir;
		private System.Windows.Forms.Label lblFile;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblCreated;
		private System.Windows.Forms.Label lblAccess;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblModified;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Decompress;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.MainMenu mainMenu1;
        private ColorDialog colorDialog1;
        private Button button1;
        private Button btnCompress;
        private Button button2;
        private FontDialog fontDialog1;
        private IContainer components;

        public Form1()
		{

           
            InitializeComponent();
			button1.Click += button1_Click;
			
			colorDialog1.FullOpen = true;
			
			colorDialog1.Color = this.BackColor;
            button2.Click += button2_Click;

            fontDialog1.ShowColor = true;

        }

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tv1 = new System.Windows.Forms.TreeView();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblModified = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAccess = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Decompress = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv1
            // 
            this.tv1.AllowDrop = true;
            this.tv1.CheckBoxes = true;
            this.tv1.Location = new System.Drawing.Point(32, 40);
            this.tv1.Name = "tv1";
            this.tv1.Size = new System.Drawing.Size(256, 277);
            this.tv1.TabIndex = 0;
            this.tv1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btnCompress
            // 
            this.btnCompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCompress.Location = new System.Drawing.Point(26, 31);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(99, 33);
            this.btnCompress.TabIndex = 2;
            this.btnCompress.Text = "CompressFiles";
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(26, 120);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(99, 34);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.ColumnWidth = 100;
            this.lstFiles.HorizontalScrollbar = true;
            this.lstFiles.Location = new System.Drawing.Point(288, 40);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.ScrollAlwaysVisible = true;
            this.lstFiles.Size = new System.Drawing.Size(186, 277);
            this.lstFiles.TabIndex = 4;
            this.lstFiles.SelectedIndexChanged += new System.EventHandler(this.lstFiles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblModified);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblAccess);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblCreated);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblFile);
            this.groupBox1.Controls.Add(this.lblDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 336);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Детали";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblModified
            // 
            this.lblModified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblModified.Location = new System.Drawing.Point(72, 176);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(184, 23);
            this.lblModified.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Modified";
            // 
            // lblAccess
            // 
            this.lblAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccess.Location = new System.Drawing.Point(72, 144);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(184, 23);
            this.lblAccess.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Access";
            // 
            // lblCreated
            // 
            this.lblCreated.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCreated.Location = new System.Drawing.Point(72, 112);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(184, 23);
            this.lblCreated.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Created";
            // 
            // lblSize
            // 
            this.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSize.Location = new System.Drawing.Point(72, 80);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(184, 23);
            this.lblSize.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size(Byte)";
            // 
            // lblFile
            // 
            this.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFile.Location = new System.Drawing.Point(72, 48);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(184, 23);
            this.lblFile.TabIndex = 3;
            // 
            // lblDir
            // 
            this.lblDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDir.Location = new System.Drawing.Point(72, 16);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(184, 23);
            this.lblDir.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "File";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dir";
            // 
            // Decompress
            // 
            this.Decompress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decompress.Location = new System.Drawing.Point(26, 80);
            this.Decompress.Name = "Decompress";
            this.Decompress.Size = new System.Drawing.Size(99, 34);
            this.Decompress.TabIndex = 6;
            this.Decompress.Text = "Decompress";
            this.Decompress.Click += new System.EventHandler(this.Decompress_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(26, 169);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRefresh.Location = new System.Drawing.Point(26, 220);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 34);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBox);
            this.groupBox2.Location = new System.Drawing.Point(312, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 232);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дата";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(24, 19);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBox.Size = new System.Drawing.Size(296, 192);
            this.txtBox.TabIndex = 0;
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_Validating);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(16, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 304);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Explorer";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCompress);
            this.groupBox4.Controls.Add(this.Decompress);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnCopy);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Location = new System.Drawing.Point(496, 26);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 304);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Действия";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(659, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Цвет";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(659, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Шрифт";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(725, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.tv1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "FileExplorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		

		private void Form1_Load(object sender, System.EventArgs e)
		{
			btnShowFiles_Click(null, null);
			
		}

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			try
			{
				TreeNode node = e.Node;
				string strFullPath = node.FullPath;
				DisplayFiles(strFullPath);
				lblDir.Text = tv1.SelectedNode.FullPath;
				lblFile.Text = "";

				DirectoryInfo fi = new DirectoryInfo(strFullPath);

				lblFile.Text = "";
				lblSize.Text = "";
				lblCreated.Text = fi.CreationTime.ToString();
				lblAccess.Text = fi.LastAccessTime.ToString();
				lblModified.Text = fi.LastWriteTime.ToString();

			}
			catch{}

		}

		private void DisplayFiles(string dirName)
		{
			try
			{
				lstFiles.Items.Clear();
				
				DirectoryInfo dir = new DirectoryInfo(dirName);
				if (!dir.Exists)
					throw new DirectoryNotFoundException
						("directory does not exist:"+dirName);

				
				foreach(DirectoryInfo di in dir.GetDirectories())
				{
					string str = "[Dir] " + di.Name;
					lstFiles.Items.Add(str);
				}

			
				foreach(FileInfo fi in dir.GetFiles())
				{
					lstFiles.Items.Add(fi.Name);
				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
		}


		private void btnCompress_Click(object sender, System.EventArgs e)
		{
			string path = Path.Combine(tv1.SelectedNode.FullPath, lstFiles.SelectedItem.ToString());
			try 
			{
				Helper.Compress.main1(path);
			}
			catch
			{
			}
			DisplayFiles(tv1.SelectedNode.FullPath);
		}

		private void btnShowFiles_Click(object sender, System.EventArgs e)
		{
			try
			{
				tv1.Nodes.Clear();
				lstFiles.Items.Clear();
				string[] drives = Environment.GetLogicalDrives();
				foreach ( string drv in drives)
				{
					TreeNode node = new TreeNode();
					node.Text = drv;
					tv1.Nodes.Add(node);
					FillDirectory(drv, node, 0);
				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}
		}
	
		private void FillDirectory(string drv, TreeNode parent, int level)
		{
			try
			{
				level++;
				if (level > 4)
					return;
				DirectoryInfo dir = new DirectoryInfo(drv);
				if (!dir.Exists)
					throw new DirectoryNotFoundException
						("directory does not exist:"+drv);

				foreach(DirectoryInfo di in dir.GetDirectories())
				{
					TreeNode child = new TreeNode();
					child.Text = di.Name;
					parent.Nodes.Add(child);
					
					FillDirectory(child.FullPath, child, level);
				}
			}
			catch(Exception ex)
			{
				ex.ToString();
			}

		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void lstFiles_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
				lblDir.Text = tv1.SelectedNode.FullPath;
				string path = Path.Combine(tv1.SelectedNode.FullPath, lstFiles.SelectedItem.ToString());
				
				FileInfo fi = new FileInfo(path);

				lblFile.Text = lstFiles.SelectedItem.ToString();
				lblSize.Text = fi.Length.ToString();
				lblCreated.Text = fi.CreationTime.ToString();
				lblAccess.Text = fi.LastAccessTime.ToString();
				lblModified.Text = fi.LastWriteTime.ToString();
				txtBox.Text = "";

				StreamReader rstr = fi.OpenText();
				string []sline = new string[65535];

				

				int count = 0;

				if (rstr != null)
				{
					count = 0;
					sline[count++] = rstr.ReadLine();
					while (sline[count-1] != null)
					{                              
						sline[count++] = rstr.ReadLine();
						if (count >= 65536) break;
					}
					rstr.Close();

					string []finalSize = new string[count];

					

					for (int i = 0; i < count; i++)

						finalSize[i]=sline[i];

					txtBox.Lines = finalSize;

				}
			}
			catch{}
		}

		private void btnCopy_Click(object sender, System.EventArgs e)
		{
			string path = Path.Combine(tv1.SelectedNode.FullPath, lstFiles.SelectedItem.ToString());
			string path2 = path + "copy";

			try 
			{
				
				using (FileStream fs = File.Create(path2)) {}

			

				File.Copy(path, path2);

				

				DisplayFiles(tv1.SelectedNode.FullPath);
			}
			catch
			{
			}		
		}

		private void Decompress_Click(object sender, System.EventArgs e)
		{
			string path = Path.Combine(tv1.SelectedNode.FullPath, lstFiles.SelectedItem.ToString());
			try 
			{
				Helper.Decompress.main2(path);
			}
			catch
			{
			}
			DisplayFiles(tv1.SelectedNode.FullPath);
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			try
			{
				string path = Path.Combine(tv1.SelectedNode.FullPath, lstFiles.SelectedItem.ToString());
				
				File.Delete(path);

				DisplayFiles(tv1.SelectedNode.FullPath);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			try 
			{
				MessageBox.Show("Inside Try");
				throw(new IOException());
			}
			catch (IOException ex) 
			{
				MessageBox.Show ("IOException Caught");
			}
			catch (Exception ex) 
			{
				MessageBox.Show("Exception Caught");
			}
			finally 
			{
				MessageBox.Show ("Inside Finally");
			}
			MessageBox.Show ("After End Try");
						
		}

		private void txtBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
		
		}

		public interface IEmployee 
		{
			double salary 
			{
				get;
			} 
		} 
		public class Employee : IEmployee 
		{ 
			private double _salary; 
			public double salary
			{ 
				get 
				{
					return _salary;
				} 
			} 
		} 
		public class ptEmployee : Employee {} 
		object o = new Object(); 
		Employee emp = new Employee(); 
		ptEmployee ptemp = new ptEmployee(); 

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			int count = 0; 
			if (ptemp.GetType().IsInstanceOfType(ptemp)) 
			{
				count += 1; 
			}
			if (emp.GetType().IsInstanceOfType(ptemp))
			{
				count += 1; 
			}
			if (o.GetType().IsInstanceOfType(ptemp))
			{
				count += 1; 
			}
			if (ptemp.GetType().IsInstanceOfType(emp))
			{
				count += 1; 
			}
			if (typeof(IEmployee).IsInstanceOfType(ptemp))
			{
				count += 1; 
			}

		MessageBox.Show(count.ToString());
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			mainMenu1.MenuItems.Clear();
		
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (colorDialog1.ShowDialog() == DialogResult.Cancel)
				return;
		
			this.BackColor = colorDialog1.Color;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.Cancel)
                return;
         
            button2.Font = fontDialog1.Font;
           
            button2.ForeColor = fontDialog1.Color;
        }
    }
}
