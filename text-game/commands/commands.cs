using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_game
{
    enum commands
    {
        help,       // show help message

        forwards,   // move
        backwards,
        left,
        right,

        look,       // rewrite place description

        invalid,    // invalid command
        nocommand,
    }
}
