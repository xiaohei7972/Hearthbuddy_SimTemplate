using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_NAX2_03H : SimTemplate //* 火焰之雨 Rain of Fire
//<b>Hero Power</b>Fire a missile for each card in your opponent's hand.
//<b>英雄技能</b>你的对手每有一张手牌，便发射一枚飞弹。 
	{



        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = 1;
			int cardCount = 0;
            if (ownplay)
            {
				cardCount = p.enemyAnzCards;
				dmg += p.ownHeroPowerExtraDamage;
                if (p.doublepriest >= 1) dmg *= (2 * p.doublepriest);
            }
            else
            {
				cardCount = p.owncards.Count;
				dmg += p.enemyHeroPowerExtraDamage;
                if (p.enemydoublepriest >= 1) dmg *= (2 * p.enemydoublepriest);
            }
						
            for (int i = 0; i < cardCount; i++)
            {
				target = (ownplay)? p.searchRandomMinion(p.enemyMinions, searchmode.searchHighAttackLowHP) : p.searchRandomMinion(p.ownMinions, searchmode.searchHighAttackLowHP);
				if (target == null) target = (ownplay) ? p.enemyHero : p.ownHero;
				p.minionGetDamageOrHeal(target, dmg);
            }
        }
	}
}