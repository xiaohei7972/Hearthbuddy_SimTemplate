using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//武器 牧师 费用：2 攻击力：2 耐久度：0
	//Crystal Tusk
	//棱晶獠牙
	//[x]<b>Battlecry:</b> Shuffle the left-most card in your hand intoyour deck. <b>Deathrattle:</b>Draw 2 cards.
	//<b>战吼：</b>将你最左边的手牌洗入你的牌库。<b>亡语：</b>抽两张牌。
	class Sim_DINO_408 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Weapon weapon, Minion target, int choice)
		{
			base.getBattlecryEffect(p, weapon, target, choice);
			if (p.owncards.Count > 0)
			{
				p.ownDeck.Add(p.owncards[0].card);
				p.removeCard(p.owncards[0]);
			}
        }
        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.drawACard(CardDB.cardIDEnum.None, m.own);
			p.drawACard(CardDB.cardIDEnum.None, m.own);
        }
	}
}
