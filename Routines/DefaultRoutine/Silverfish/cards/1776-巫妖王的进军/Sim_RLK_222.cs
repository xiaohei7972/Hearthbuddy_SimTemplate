
using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 阿斯塔洛·血誓 Astalor Bloodsworn
    //&lt;b&gt;战吼：&lt;/b&gt;将护卫阿斯塔洛置入你的手牌。&lt;b&gt;法力渴求（5）：&lt;/b&gt;造成2点伤害。
    //&lt;b&gt;Battlecry:&lt;/b&gt; Add Astalor, the Protector to your hand. &lt;b&gt;Manathirst (5):&lt;/b&gt; Deal 2 damage.
    class Sim_RLK_222 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.RLK_222t1, own.own, true);
        }

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice, Handmanager.Handcard hc)
        {
            if (p.ownMaxMana >= hc.card.Manathirst)
            {
                if (target != null)
                    p.minionGetDamageOrHeal(target, 2);
            }
        }
        
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), // 没有目标时也能用
            };
        }
    }

}
