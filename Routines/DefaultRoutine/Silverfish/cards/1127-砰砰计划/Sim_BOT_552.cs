using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_552 : SimTemplate //* 群星罗列者 Star Aligner
//[x]<b>Battlecry:</b> If you control 3minions with 7 Health, deal7 damage to all enemies.
//<b>战吼：</b>如果你控制三个生命值为7的随从，对所有敌人造成7点伤害。 
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
            int Hp7Num = 0;
            foreach (Minion m in temp)
            {
                if (m.Hp == 7) Hp7Num++;
            }
            if (Hp7Num == 3) p.allCharsOfASideGetDamage(!own.own, 7);
        }
    }
}