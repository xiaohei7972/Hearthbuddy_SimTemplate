using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOD_038 : SimTemplate //* 天空上将库拉格 Sky Gen'ral Kragg
	{
        //[x]<b>Taunt</b><b>Battlecry:</b> If you've played a<b>Quest</b> this game, summon a4/2 Parrot with <b>Rush</b>.
        //<b>嘲讽，战吼：</b>如果你在本局对战中使用过<b>任务</b>，则召唤一只4/2并具有<b>突袭</b>的鹦鹉。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach(var item in Probabilitymaker.Instance.ownGraveyard)
            {
                if(CardDB.Instance.getCardDataFromID(item.Key).Quest || CardDB.Instance.getCardDataFromID(item.Key).Questline)
                {
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.YOD_038t), own.zonepos, true );
                }
            }
        }

    }
}
