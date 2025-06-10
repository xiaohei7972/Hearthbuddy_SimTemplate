using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_026 : SimTemplate //* 奥尔多真理追寻者 Aldor Truthseeker
	{
		//<b>Taunt</b>. <b>Battlecry:</b> Reduce the Cost of your Librams by (2) this game.
		//<b>嘲讽，战吼：</b>在本局对战中，你的圣契的法力值消耗减少（2）点。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.libram += 2;
			//foreach(Handmanager.Handcard hc in p.owncards){
			//	switch (hc.card.chnName)
   //             {
   //                 case CardDB.cardNameCN.希望圣契:
   //                 case CardDB.cardNameCN.正义圣契:
   //                 case CardDB.cardNameCN.智慧圣契:
   //                 case CardDB.cardNameCN.审判圣契:
   //                     hc.manacost -= 2;
   //                     break;
   //             }
			//}
        }
		
	}
}
