using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 沃金 Vol'jin
    //<b>Battlecry:</b> Swap Health with another minion.
    //<b>战吼：</b>与另一个随从交换生命值。 
    class Sim_GVG_014 : SimTemplate
    {
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 确保目标随从有效
            if (target != null)
            {
                // 交换生命值
                int tempHealth = own.Hp;
                own.Hp = target.Hp;
                target.Hp = tempHealth;

                // 调整最大生命值
                own.maxHp = own.Hp;
                target.maxHp = target.Hp;

                // 确保生命值不低于1
                if (own.Hp < 1) own.Hp = 1;
                if (target.Hp < 1) target.Hp = 1;
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[]{
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), //需要目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), //目标只能是随从
				new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE), //无目标时也可以用
			};
        }

        // public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        // {
        //     if (target == null) return;

        //     own.maxHp = target.Hp;
        //     target.maxHp = own.Hp;

        //     own.Hp = own.maxHp;
        //     target.Hp = target.maxHp;
        //     if (target.wounded)
        //     {
        //         target.wounded = false;
        //         target.handcard.card.sim_card.onEnrageStop(p, target);
        //     }
        // }

        // public override PlayReq[] GetPlayReqs()
        // {
        //     return new PlayReq[] {
        //         new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
        //         new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE),
        //     };
        // }
    }
}