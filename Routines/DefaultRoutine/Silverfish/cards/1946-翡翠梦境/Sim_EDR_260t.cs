using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //随从 中立 费用：4 攻击力：4 生命值：5
    //Illusion
    //幻象
    //<b>Summoned When Drawn</b><b>Taunt</b>
    //<b>抽到时召唤</b><b>嘲讽</b>
    class Sim_EDR_260t : SimTemplate
    {

        //获取幻影id

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_260t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice) // 施放
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count; // 位置
            p.callKid(kid, pos, ownplay, false);
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), // 需要一个空位
            };
        }
    }
}
