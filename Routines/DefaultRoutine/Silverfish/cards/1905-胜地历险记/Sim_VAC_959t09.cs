using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：1
	//Amulet of Mobility
	//灵动护符
	//Draw 3 cards.<i>(Discard 2 of them!)</i>
	//抽三张牌。<i>（弃掉其中两张！）</i>
	class Sim_VAC_959t09 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
        }


    }
}
