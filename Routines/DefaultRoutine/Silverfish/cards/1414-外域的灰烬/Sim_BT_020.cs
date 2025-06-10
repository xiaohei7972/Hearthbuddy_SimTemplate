using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_020 : SimTemplate //* 奥尔多侍从 Aldor Attendant
	{
		//<b>Battlecry:</b> Reduce the Cost_of your Librams by_(1) this game.
		//<b>战吼：</b>在本局对战中，你的圣契的法力值消耗减少（1）点。
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.libram += 1;//圣契指示物加1
			//foreach(Handmanager.Handcard hc in p.owncards){
			//	switch (hc.card.chnName)
   //             {
   //                 case CardDB.cardNameCN.希望圣契:
   //                 case CardDB.cardNameCN.正义圣契:
   //                 case CardDB.cardNameCN.智慧圣契:
   //                 case CardDB.cardNameCN.审判圣契:
   //                     hc.manacost -= 1;
   //                     break;
   //             }
			//}
		}
		
	}
}
