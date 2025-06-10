using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_891 : SimTemplate //* 怒火（等级1） Fury (Rank 1)
	{
        //Give your hero +2 Attack this turn. <i>(Upgrades when you have 5 Mana.)</i>
        //在本回合中，使你的英雄获得+2攻击力。<i>（当你有5点法力值时升级。）</i>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetTempBuff(p.ownHero, 2, 0);
            p.ownHero.updateReadyness();
        }

    }
}
