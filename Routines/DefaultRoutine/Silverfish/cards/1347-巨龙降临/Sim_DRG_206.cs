using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_206 : SimTemplate //* 火焰之雨 Rain of Fire
	{
        //Deal $1 damage to all_characters.
        //对所有角色造成$1点伤害。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int damge = p.getSpellDamageDamage(1);
            p.allCharsOfASideGetDamage(true, 1);
            p.allCharsOfASideGetDamage(false, 1);
        }

    }
}
