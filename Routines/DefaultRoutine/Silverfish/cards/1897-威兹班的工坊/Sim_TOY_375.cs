using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TOY_375 : SimTemplate // Skating Elemental
    {
        // <b>战吼：</b> <b>冻结</b>一个敌方随从，获得等同于其攻击力的护甲值。
        
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (target != null && !target.own)
            {
                p.minionGetFrozen(target); // 冻结目标随从
                int armorGain = target.Angr;
                p.minionGetArmor(p.ownHero, armorGain); // 获得护甲
            }
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
    }
}
