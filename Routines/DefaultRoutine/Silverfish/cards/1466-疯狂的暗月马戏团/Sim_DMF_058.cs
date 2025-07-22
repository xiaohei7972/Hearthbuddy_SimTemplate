using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_058 : SimTemplate //* 日蚀 Solar Eclipse
	{
        //Your next spell this turn casts twice.
        //在本回合中，你的下一个法术将施放两次。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.anzSolor = true;
        }

    }
}
