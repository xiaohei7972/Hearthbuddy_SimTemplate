using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_730t : SimTemplate //* 月触项链 Moontouched Amulet
	{
        //<b>Corrupted</b>Give your hero +4 Attack this turn. Gain 6 Armor.
        //<b>已腐蚀</b>在本回合中，使你的英雄获得+4攻击力。获得6点护甲值。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetArmor(p.ownHero, 6);
            p.minionGetTempBuff(p.ownHero, 4, 0);
        }

    }
}
