using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Shared colours and small visual helpers so every form reads as one product.
    /// </summary>
    public static class UiTheme
    {
        public static readonly Color DeepGreen = Color.FromArgb(13, 83, 14);
        public static readonly Color MidGreen = Color.FromArgb(47, 122, 58);
        public static readonly Color AccentGreen = Color.FromArgb(27, 94, 32);
        public static readonly Color Cream = Color.FromArgb(248, 244, 232);
        public static readonly Color PageBackground = Color.FromArgb(241, 243, 240);
        public static readonly Color CardBackground = Color.White;
        public static readonly Color BodyText = Color.FromArgb(60, 64, 67);
        public static readonly Color MutedText = Color.FromArgb(95, 99, 104);
        public static readonly Color HintText = Color.FromArgb(160, 163, 166);
        public static readonly Color FieldBorder = Color.FromArgb(214, 217, 212);

        public static readonly Color PendingText = Color.FromArgb(120, 100, 0);
        public static readonly Color PendingFill = Color.FromArgb(255, 249, 224);
        public static readonly Color ProgressText = Color.FromArgb(176, 101, 0);
        public static readonly Color ProgressFill = Color.FromArgb(255, 243, 224);
        public static readonly Color CompletedText = Color.FromArgb(21, 101, 192);
        public static readonly Color CompletedFill = Color.FromArgb(227, 242, 253);
        public static readonly Color CancelledText = Color.FromArgb(179, 38, 30);
        public static readonly Color CancelledFill = Color.FromArgb(253, 236, 234);

        /// <summary>Colour pair used to tint a status cell in a grid.</summary>
        public static void StatusColors(string status, out Color fill, out Color text)
        {
            switch (status)
            {
                case RequestStatus.InProgress: fill = ProgressFill; text = ProgressText; break;
                case RequestStatus.Completed: fill = CompletedFill; text = CompletedText; break;
                case RequestStatus.Cancelled: fill = CancelledFill; text = CancelledText; break;
                default: fill = PendingFill; text = PendingText; break;
            }
        }

        public static Color PriorityColor(string priority)
        {
            switch (priority)
            {
                case "High": return CancelledText;
                case "Medium": return ProgressText;
                default: return MutedText;
            }
        }

        /// <summary>Clips a control into a circle — used for status dots and avatars.</summary>
        public static void MakeCircular(Control control)
        {
            var circle = new GraphicsPath();
            circle.AddEllipse(0, 0, control.Width, control.Height);
            control.Region = new Region(circle);
        }

        /// <summary>Clips a control into a rounded rectangle.</summary>
        public static void MakeRounded(Control control, int radius)
        {
            control.Region = new Region(RoundedPath(new Rectangle(Point.Empty, control.Size), radius));
        }

        public static GraphicsPath RoundedPath(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Shows greyed hint text in an empty field and clears it on focus, so the
        /// login and request forms explain themselves without extra labels.
        /// </summary>
        public static void ApplyPlaceholder(TextBox field, string hint, Color activeColor)
        {
            bool isPassword = field.UseSystemPasswordChar;

            Action showHint = () =>
            {
                field.UseSystemPasswordChar = false;
                field.ForeColor = HintText;
                field.Text = hint;
            };

            if (string.IsNullOrEmpty(field.Text)) showHint();

            field.GotFocus += (s, e) =>
            {
                if (field.ForeColor != HintText) return;
                field.Text = string.Empty;
                field.ForeColor = activeColor;
                field.UseSystemPasswordChar = isPassword;
            };

            field.LostFocus += (s, e) =>
            {
                if (field.Text.Length == 0) showHint();
            };
        }

        /// <summary>True when the field holds real input rather than its placeholder.</summary>
        public static string ValueOf(TextBox field)
        {
            return field.ForeColor == HintText ? string.Empty : field.Text.Trim();
        }

        /// <summary>Styles a combo box to match the flat field look used elsewhere.</summary>
        public static void StyleCombo(ComboBox combo, params string[] items)
        {
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
            combo.FlatStyle = FlatStyle.Flat;
            combo.Font = new Font("Segoe UI", 10.2F);
            combo.ForeColor = BodyText;
            combo.BackColor = Color.White;
            combo.Cursor = Cursors.Hand;
            combo.Items.Clear();
            combo.Items.AddRange(items);
        }

        /// <summary>Paints a subtle border around a card panel.</summary>
        public static void OutlineCard(object sender, PaintEventArgs e)
        {
            var panel = (Panel)sender;
            using (var pen = new Pen(Color.FromArgb(230, 232, 228)))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
            }
        }
    }
}
