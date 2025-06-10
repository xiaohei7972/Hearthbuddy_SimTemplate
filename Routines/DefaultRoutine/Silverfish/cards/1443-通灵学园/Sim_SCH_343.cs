using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_SCH_343 : SimTemplate //* 虚空吸食者 Void Drinker
    {
        //[x]<b>Taunt</b>. <b>Battlecry:</b> Destroya Soul Fragment in yourdeck to gain +3/+3.
        //<b>嘲讽，战吼：</b>摧毁一张你牌库中的灵魂残片，获得+3/+3。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (own.own)
            {
                if (p.AnzSoulFragments > 0)
                {
                    p.AnzSoulFragments--;
                    p.ownDeckSize--;
                    p.minionGetBuffed(own, 3, 3);
                }
            }
            else
            {
                p.enemyDeckSize--;
                p.minionGetBuffed(own, 3, 3);
            }
        }
    }
}
