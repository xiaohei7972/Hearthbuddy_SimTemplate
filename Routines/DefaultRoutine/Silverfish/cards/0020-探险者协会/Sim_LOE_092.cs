using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOE_092 : SimTemplate //* 虚灵大盗拉法姆 Arch-Thief Rafaam
//<b>Battlecry: Discover</b> a powerful Artifact.
//<b>战吼：发现</b>一张强大的神器牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.lanternofpower, own.own, true);
		}
	}
}