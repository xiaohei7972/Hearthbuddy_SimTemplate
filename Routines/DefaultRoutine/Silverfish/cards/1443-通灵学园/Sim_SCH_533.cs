using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_533 : SimTemplate //* 毕业仪式 Commencement
	{
        //Summon a minion from your deck. Give it <b>Taunt</b> and <b>Divine Shield</b>.
        //从你的牌库中召唤一个随从。使其获得<b>嘲讽</b>和<b>圣盾</b>。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // TODO 读取牌库随机召唤一个随从
            p.evaluatePenality -= 30;
        }

    }
}
