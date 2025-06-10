using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SCH_162 : SimTemplate //* 维克图斯 Vectus
	{
        //[x]<b>Battlecry:</b> Summon two1/1 Whelps. Each gains a<b>Deathrattle</b> from your minionsthat died this game.
        //<b>战吼：</b>召唤两条1/1的雏龙。每条雏龙获得一个本局对战中死亡的友方随从的<b>亡语</b>。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_162t), own.zonepos, own.own);
            p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SCH_162t), own.zonepos, own.own);

            int cnt = 2;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
            {
                bool died = true;
                // 如果就在场上不认为已死亡
                foreach (Minion mm in p.ownMinions)
                {
                    if (mm.handcard.card.cardIDenum == e.Key && e.Value < 2)
                    {
                        died = false;
                        break; ;
                    }
                }
                // 死亡随从
                CardDB.Card rebornMob = CardDB.Instance.getCardDataFromID(e.Key);
                // 不是已死亡随从退出
                if (!died || rebornMob.type != CardDB.cardtype.MOB) continue;
                if (cnt <= 0) break;
                if (rebornMob.deathrattle)
                {
                    cnt--;
                    //Helpfunctions.Instance.ErrorLog("雏龙将获得"+rebornMob.chnName+"的亡语（还没实现）");
                    p.evaluatePenality -= 10;
                }
            }
        }

    }
}
