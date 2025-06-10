using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_109 : SimTemplate //* 暗月先知赛格 Sayge, Seer of Darkmoon
	{
		//<b>Battlecry:</b> Draw @ |4(card, cards).<i>(Upgraded for eachfriendly <b>Secret</b> that hastriggered this game!)</i>
		//<b>战吼：</b>抽@张牌。<i>（在本局对战中，每触发一个友方<b>奥秘</b>都会升级！）</i>
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			//不准确写法 抽四张
            p.drawACard(CardDB.cardNameEN.unknown, own.own, false);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, false);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, false);
			p.drawACard(CardDB.cardNameEN.unknown, own.own, false);
        }
		
	}
}
