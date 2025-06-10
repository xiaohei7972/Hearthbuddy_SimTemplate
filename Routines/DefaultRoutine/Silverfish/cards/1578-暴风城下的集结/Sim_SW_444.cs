using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_444 : SimTemplate //* 暮光欺诈者 Twilight Deceptor
	{
        //<b>Battlecry:</b> If any hero took damage this turn, draw a Shadow spell.
        //<b>战吼：</b>如果有英雄在本回合中受到伤害，抽一张暗影法术牌。

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 检查本回合是否有英雄受到伤害
            bool heroTookDamage = p.enemyHero.Hp < p.enemyHeroTurnStartedHp || p.ownHero.Hp < p.ownHeroTurnStartedHp;

            if (heroTookDamage)
            {
                // 查找牌库中是否有暗影法术
                foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
                {
                    CardDB.cardIDEnum deckCard = kvp.Key;
                    CardDB.Card card = CardDB.Instance.getCardDataFromID(deckCard);

                    if (card.SpellSchool == CardDB.SpellSchool.SHADOW && card.type == CardDB.cardtype.SPELL)
                    {
                        // 抽一张暗影法术牌
                        p.drawACard(deckCard, own.own, true);
                        return;
                    }
                }
            }
        }
    }
}
