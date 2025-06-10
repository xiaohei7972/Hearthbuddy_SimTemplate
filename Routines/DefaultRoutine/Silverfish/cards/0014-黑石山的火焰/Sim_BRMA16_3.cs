using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BRMA16_3 : SimTemplate //* 音波吐息 Sonic Breath
	{
        //Deal $3 damage to a minion. Give your weapon +3 Attack.
        //对一个随从造成$3点伤害。使你的武器获得+3攻击力。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay)
            {
                int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                p.minionGetDamageOrHeal(target, dmg);
                if(p.ownWeapon.Durability > 0)
                {
                    p.ownWeapon.Angr += 3;
                }
            }
        }



        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_WEAPON_EQUIPPED),
            };
        }
	}
}
