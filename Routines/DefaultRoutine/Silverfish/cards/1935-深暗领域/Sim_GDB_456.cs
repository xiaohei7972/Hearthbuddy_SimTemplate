using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：2
	//Spontaneous Combustion
	//自燃
	//Deal $4 damage to a random enemy. If you played an Elemental last turn, choose the target.
	//随机对一个敌人造成$4点伤害。如果你在上个回合使用过元素牌，则可以选择目标。
	class Sim_GDB_456 : SimTemplate
    {
        //<b>Deal 4 damage to a random enemy. If you played an Elemental last turn, choose the target.</b>
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            int dmg = 0;
            if (target.own != ownplay) dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4); // 如果目标不是自己，则使用伤害
            p.minionGetDamageOrHeal(target, dmg);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要目标   
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要敌方目标
            };
        }
    }
}