using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GumshoeRacer
{
    public partial class MainForm : Form
    {
        private Boolean _hoverPaint, mouseDown;
        private Point startPoint;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        #region DLL Import
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        #endregion

        public static extern bool ReleaseCapture();

        public MainForm()
        {
            InitializeComponent();
            var listItem = new ListViewItem("Jimmy");
            rankListView.Items.Add(listItem).SubItems.AddRange(new[] { "424, 411", "Level 16" });
        }

        #region Title Bar and Buttons
        private void closePanel_MouseEnter(object sender, EventArgs e)
        {
            _hoverPaint = true;
            closeLabel.Visible = false;
            closePanel.Refresh();
        }

        private void closePanel_MouseLeave(object sender, EventArgs e)
        {
            _hoverPaint = false;
            closeLabel.Visible = true;
            closePanel.Refresh();
        }

        private void closePanel_Paint(object sender, PaintEventArgs e)
        {
            if (_hoverPaint == false) return;
            HoverBorder(e);
        }

        private void closePanel_MouseClick(object sender, MouseEventArgs e)
        {
            Dispose(true);
        }

        private void minimizePanel_MouseEnter(object sender, EventArgs e)
        {
            _hoverPaint = true;
            minimizeLabel.Visible = false;
            minimizePanel.Refresh();
        }

        private void minimizePanel_MouseLeave(object sender, EventArgs e)
        {
            _hoverPaint = false;
            minimizeLabel.Visible = true;
            minimizePanel.Refresh();
        }

        private void minimizePanel_Paint(object sender, PaintEventArgs e)
        {
            if (_hoverPaint == false) return;
            HoverBorder(e);
        }

        private void minimizePanel_MouseClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            minimizeLabel.Visible = true;
            minimizePanel.Refresh();
        }

        private void titlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void titleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        #endregion

        #region Custom Methods
        private void HoverBorder(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.DeepSkyBlue,
                e.ClipRectangle.Left,
                e.ClipRectangle.Top,
                e.ClipRectangle.Width - 1,
                e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }
        #endregion

        private void nameTextBox_MouseEnter(object sender, EventArgs e)
        {
            _hoverPaint = true;
            namePanel.Refresh();
        }

        private void nameTextBox_MouseLeave(object sender, EventArgs e)
        {
            _hoverPaint = false;
            namePanel.Refresh();
        }

        private void namePanel_Paint(object sender, PaintEventArgs e)
        {
            if (_hoverPaint) HoverBorder(e);
        }

        private void rankListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            rankListView.SelectedItems.Clear();
        }

        private void rankListView_MouseEnter(object sender, EventArgs e)
        {
            _hoverPaint = true;
            listviewPanel.Refresh();
        }

        private void rankListView_MouseLeave(object sender, EventArgs e)
        {
            _hoverPaint = false;
            listviewPanel.Refresh();
        }

        private void listviewPanel_Paint(object sender, PaintEventArgs e)
        {
            if (_hoverPaint) HoverBorder(e);
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char) Keys.Enter) return;
            Populate();

        }

        private void Populate()
        {
            
        }

    }
}
