using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_AV_293 : SimTemplate //* 空军指挥官穆维里克 wingcommandermulverick
    {
        //<b>突袭</b>。你的随从获得“<b>荣誉消灭：</b>召唤一只2/2 并具有<b>突袭</b>的双足飞龙。”
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_293t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = p.ownMinions.Count;
            foreach (Minion mm in p.enemyMinions)
            {
                if (mm.Hp == target.Angr && !mm.divineshild)
                {
                    p.evaluatePenality -= (mm.Hp + mm.Angr) * 2;
                    p.callKid(kid, pos + 1, ownplay);
                }
                else
                {
                    p.evaluatePenality += 5;
                }
            }

        }
    }
}
