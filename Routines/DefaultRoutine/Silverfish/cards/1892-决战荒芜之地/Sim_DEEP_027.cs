using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：4 攻击力：6 生命值：8
	//Gloomstone Guardian
	//暗石守卫
	//[x]<b>Taunt</b>. <b>Choose One -</b>Discard 2 cards; or Destroyone of your Mana Crystals.<b>Forge:</b> Do NEITHER.
	//<b>嘲讽</b>。<b>抉择：</b>弃两张牌；或者摧毁你的一个法力水晶。<b>锻造：</b>无需弃牌或摧毁。
	class Sim_DEEP_027 : SimTemplate
	{
		public override void onCardPlay(Playfield p, Minion own, Minion target, int choice)
		{
			if (choice == 1 || (p.ownFandralStaghelm > 0 && own.own))
			{
				p.discardCards(2, own.own);
			}
			if (choice == 2 || (p.ownFandralStaghelm > 0 && own.own))
			{
				p.ownMaxMana = Math.Max(0, p.ownMaxMana--);
			}


		}
		
	}
}
