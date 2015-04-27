using System;
using System.Collections.Generic;
using System.Text;

namespace RhymeLib {
    /// <summary>
    /// An extension of the Textbox control to override the context menu with a list of rhyming words.
    /// </summary>
    public class RhymeAssistTextbox : System.Windows.Forms.TextBox {
        private System.Windows.Forms.ContextMenu _context = new System.Windows.Forms.ContextMenu();
        private EventHandler _popupDelegate;
        private EventHandler _menuClickDelegate;
        private System.Drawing.Point _mouseLocation;

        public RhymeAssistTextbox() {
            _popupDelegate = new EventHandler(_context_Popup);
            _menuClickDelegate = new EventHandler(mi_Click);

            base.Multiline = true;
            base.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            base.AcceptsTab = true;

            base.ContextMenu = _context;
            base.ContextMenu.Popup += _popupDelegate;
        }

        /// <summary>
        /// Event raised when the user right-clicks in the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _context_Popup(object sender, EventArgs e) {
            string word = SelectedText.Trim();
            if (word.Length > 0) {
                // Show the wait cursor in case the web service call takes a little while.
                System.Windows.Forms.Cursor c = Cursor;
                base.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                base.ContextMenu.MenuItems.Clear();

                _context = new System.Windows.Forms.ContextMenu();

                List<string> rhymingWords = RhymingWords.GetRhymes(word);

                // Assign the click events to the same handler and determine what was picked there.
                foreach (string rhymedWord in rhymingWords)
                    _context.MenuItems.Add(new System.Windows.Forms.MenuItem(rhymedWord, _menuClickDelegate));

                if (rhymingWords.Count == 0) {
                    System.Windows.Forms.MenuItem mi = new System.Windows.Forms.MenuItem("[No rhymes found]");
                    mi.Enabled = false;
                    _context.MenuItems.Add(mi);
                }

                // Show the menu of the rhyming words.
                base.ContextMenu = _context;
                base.Cursor = c;
                base.ContextMenu.Show(this, _mouseLocation);

                // Seem to have to unsubscribe and resubscribe 
                // or this popup menu handler isn't called.
                base.ContextMenu.Popup -= _popupDelegate;
                base.ContextMenu.Popup += _popupDelegate;
            }
        }

        /// <summary>
        /// Remember the mouse location when a click occurs to know where to popup the context menu
        /// if it's requested.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) {
            _mouseLocation = e.Location;
        }

        /// <summary>
        /// The event raised when the user selects a rhyming word from the menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mi_Click(object sender, EventArgs e) {
            // The user has picked a rhyming word.  Put it on the clipboard for pasting.
            System.Windows.Forms.Clipboard.SetText(((System.Windows.Forms.MenuItem)sender).Text);
        }
    }
}
