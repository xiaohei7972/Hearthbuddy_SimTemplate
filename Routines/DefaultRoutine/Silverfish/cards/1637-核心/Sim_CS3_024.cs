using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CS3_024 : SimTemplate //* 泰兰·弗丁 Taelan Fordring
	{
		//[x]<b><b>Taunt</b>, Divine Shield</b><b>Deathrattle:</b> Draw yourhighest Cost minion.
		//<b>嘲讽</b>，<b>圣盾</b><b>亡语：</b>抽取你的法力值消耗最高的随从牌。
		public override void onDeathrattle(Playfield p, Minion m)
		{
			CardDB.cardNameEN NameEnum = CardDB.cardNameEN.unknown;
			int maxCost = 0;
            foreach(KeyValuePair<CardDB.cardIDEnum, int>kvp in p.prozis.turnDeck )
			{
				// ID 转卡
				CardDB.cardIDEnum deckCard = kvp.Key;
				CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
				if(deckSpell.type == CardDB.cardtype.MOB && deckSpell.cost > maxCost){
                    maxCost = deckSpell.cost;                 
					NameEnum = deckSpell.nameEN;
                }
			}
			if(NameEnum != CardDB.cardNameEN.unknown){
				p.drawACard(NameEnum, m.own);
			}
		}
		
	}
}
