using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    
    // Adjust Active Form's Title Bar Position

    internal class TitleBarAction
    {
        private bool mov;
        private int movX, movY;

        public void MouseDown(int X, int Y)
        {
            mov = true;
            movX = X;
            movY = Y;
        }

        public void MouseUp()
        {
            mov = false;
        }

        public void MouseMove(int MousePosX, int MousePosY)
        {           
            if (mov)
            {
                 Form.ActiveForm.SetDesktopLocation(MousePosX - movX, MousePosY - movY);
            }
        }
    }
   
}
