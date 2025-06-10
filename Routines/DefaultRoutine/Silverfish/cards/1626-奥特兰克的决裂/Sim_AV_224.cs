using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_224 : SimTemplate //* 布置陷阱 springthetrap
	{
		//对一个随从造成$3点伤害，从你的牌库中施放一个<b>奥秘</b>。<b>荣誉消灭：</b>改为施放两个。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int dmg = p.getSpellDamageDamage(3);
            if (target != null)
            {
                p.minionGetDamageOrHeal(target, dmg);
                p.ownSecretsIDList.Add(CardDB.cardIDEnum.None);
                if (dmg == target.Hp && !target.divineshild) {
                    p.ownSecretsIDList.Add(CardDB.cardIDEnum.None);
                }
            }
            
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
            };
        }
		
	}
}
