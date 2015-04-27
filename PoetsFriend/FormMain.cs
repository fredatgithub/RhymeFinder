using System;
using System.IO;
using System.Windows.Forms;

namespace PoetsFriend
{
  public partial class FormMain : Form
  {
    private string _fileName = string.Empty;
    private string _formName = string.Empty;
    private bool _modified = false;

    public FormMain()
    {
      InitializeComponent();
      _formName = Text;
    }

    private void mnuFileQuit_Click(object sender, EventArgs e)
    {
      if (Modified)
      {
        // ask user if he wants to save the poem TODO

      }

      Application.Exit();
    }

    private void mnuFileOpen_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog ofd = new OpenFileDialog())
      {
        ofd.Title = "Open a poem";
        ofd.Filter = "All text files (*.txt)|*.txt";
        ofd.Multiselect = false;

        if (ofd.ShowDialog(this) == DialogResult.OK)
        {
          _fileName = ofd.FileName;

          using (StreamReader sr = new StreamReader(_fileName))
          {
            txtPoem.Text = sr.ReadToEnd();
            sr.Close();
            Modified = false;
          }
        }
      }
    }

    private string FileName
    {
      set
      {
        _fileName = value;
        Text = _formName + " " + _fileName + (_modified ? "*" : string.Empty);
      }
    }

    private bool Modified
    {
      get { return _modified; }
      set
      {
        _modified = value;
        Text = _formName + " " + _fileName + (_modified ? "*" : string.Empty);
      }
    }

    private void Save()
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(_fileName))
        {
          sw.Write(txtPoem.Text);
          sw.Close();
        }

        Modified = false;
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message, "Poem didn't save", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void SaveAs()
    {
      using (SaveFileDialog sfd = new SaveFileDialog())
      {
        sfd.Title = "Save your poem";
        sfd.OverwritePrompt = true;
        sfd.Filter = "All text files (*.txt)|*.txt";
        sfd.DefaultExt = ".txt";

        if (sfd.ShowDialog(this) == DialogResult.OK)
        {
          FileName = sfd.FileName;
          Save();
        }
      }
    }

    private void mnuFileSave_Click(object sender, EventArgs e)
    {
      if (_fileName != string.Empty) Save();
      else SaveAs();
    }

    private void mnuFileSaveAs_Click(object sender, EventArgs e)
    {
      SaveAs();
    }

    private void txtPoem_TextChanged(object sender, EventArgs e)
    {
      Modified = true;
    }

    private void mnuHelpAbout_Click(object sender, EventArgs e)
    {
      using (AboutBox about = new AboutBox())
      {
        about.ShowDialog(this);
      }
    }

    private void mnuFormatFont_Click(object sender, EventArgs e)
    {
      using (FontDialog fd = new FontDialog())
      {
        fd.Font = txtPoem.Font;

        if (fd.ShowDialog(this) == DialogResult.OK)
          txtPoem.Font = fd.Font;
      }
    }
  }
}