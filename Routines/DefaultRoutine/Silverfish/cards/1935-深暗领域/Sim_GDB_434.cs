using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：4 攻击力：3 生命值：6
	//Bolide Behemoth
	//流彩巨岩
	//[x]<b>Battlecry:</b> Your Asteroids deal1 more damage this game.<b><b>Spellburst</b>:</b> Shuffle 3 ofthem into your deck.
	//<b>战吼：</b>在本局对战中，你的小行星造成的伤害增加1点。<b><b>法术迸发</b>：</b>将3张小行星洗入你的牌库。
	class Sim_GDB_434 : SimTemplate
	{
/*
		CardDB.Card eruptionCard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GDB_430); // 爆发卡的ID

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 洗入5张爆发牌


			 if (triggerEffectMinion.own == turnEndOfOwner) // 如果是在玩家回合结束时触发
			 {

			 }
        }

		public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
		{
			if (m.own == ownplay && m.Spellburst && hc.card.type == CardDB.cardtype.SPELL)
			{
				m.Spellburst = false;
                for (int i = 0; i < 3; i++)
                {
                    p.AddToDeck(eruptionCard);
                }
			}
		}
*/
		
	}
}
