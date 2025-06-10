using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_KAR_061 : SimTemplate //* 馆长 The Curator
//<b>Taunt</b><b>Battlecry:</b> Draw a Beast, Dragon, and Murloc from your deck.
//<b>嘲讽，战吼：</b>从你的牌库中抽一张野兽牌、龙牌和鱼人牌。 
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own)
			{
				//检测牌库是否有野兽并抽取
				var drawPed = p.CheckTurnDeckExists(TAG_RACE.PET);
				if (drawPed != CardDB.cardIDEnum.None) p.drawACard(drawPed, true);
				//检测牌库是否有龙并抽取
				var drawDragon = p.CheckTurnDeckExists(TAG_RACE.DRAGON);
				if (drawDragon != CardDB.cardIDEnum.None) p.drawACard(drawDragon, true);
				//检测牌库是否有鱼人并抽取
				var drawMurloc = p.CheckTurnDeckExists(TAG_RACE.MURLOC);
				if (drawMurloc != CardDB.cardIDEnum.None) p.drawACard(drawMurloc, true);
			} 
			else
            {
				p.drawACard(CardDB.cardIDEnum.None, false);
				p.drawACard(CardDB.cardIDEnum.None, false);
            }
		}
	}
}