using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：5
	//Star Power
	//星辰能量
	//[x]Deal $5 damage to arandom enemy minion.Repeat this with 1less damage.
	//随机对一个敌方随从造成$5点伤害。重复此效果，每次伤害减少1点。
	class Sim_JAM_002 : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);

            target = null;
            if (ownplay)
            {
                target = p.getEnemyCharTargetForRandomSingleDamage(dmg, true);
            }
            else
            {
                target = p.searchRandomMinion(p.ownMinions, searchmode.searchHighestAttack); 
            }
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要随从目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
            };
        }   

	}
}
