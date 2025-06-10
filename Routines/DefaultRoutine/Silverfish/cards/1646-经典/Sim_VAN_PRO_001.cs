using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_PRO_001 : SimTemplate //* 精英牛头人酋长 Elite Tauren Chieftain
//<b>Battlecry:</b> Give both players the power to ROCK! (with a Power Chord card)
//<b>战吼：</b>让两位玩家都具有摇滚的能力！（双方各获得一张强力和弦牌） 
	{


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.roguesdoit, true, true);
            p.drawACard(CardDB.cardNameEN.roguesdoit, false, true);
		}

	}
}