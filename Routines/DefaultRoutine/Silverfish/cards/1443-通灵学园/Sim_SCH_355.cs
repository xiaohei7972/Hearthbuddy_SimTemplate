using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_355 : SimTemplate //* 残片震爆秘术师 Shardshatter Mystic
	{
        //<b>Battlecry:</b> Destroy a Soul Fragment in your deck to deal 3 damage to all other minions.
        //<b>战吼：</b>摧毁一张你牌库中的灵魂残片，对所有其他随从造成3点伤害。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.AnzSoulFragments > 0)
                {
                    p.AnzSoulFragments--;
                    p.ownDeckSize--;
                    p.allMinionsGetDamage(3, own.entitiyID);
                }
            }
            else
            {
                p.enemyDeckSize--;
                p.allMinionsGetDamage(3, own.entitiyID);
            }
        }
    }
}
