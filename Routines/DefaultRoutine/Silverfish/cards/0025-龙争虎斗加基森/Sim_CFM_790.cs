using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_790 : SimTemplate //* 卑劣的脏鼠 Dirty Rat
//[x]<b>Taunt</b><b>Battlecry:</b> Your opponentsummons a random minionfrom their hand.
//<b>嘲讽，战吼：</b>使你的对手随机从手牌中召唤一个随从。 
	{
		

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_066);
        CardDB.Card kidActual = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_450t4);


        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int zonepos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            if (Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_450t2)
                && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_450t4)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_091t3)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_091t4)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_322t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_322t4)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_028t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_028t5)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_428t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_428t4)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_039t3)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_039t3_t)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_313t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_313t4)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_433t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_433t3)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_052t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_052t4)
                || Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_031t2)
                    && !Probabilitymaker.Instance.enemyGraveyard.ContainsKey(CardDB.cardIDEnum.SW_031t7)
                            )
            {
                p.callKid(kidActual, zonepos, !m.own);
                p.evaluatePenality -= 14 * 4 + 60;
                return;
            }
            p.callKid(kid, zonepos, !m.own);
            // 如果没有处理掉对方生物的能力请不要使用
            p.enemyMinions[p.enemyMinions.Count - 1].Angr = 10;
        }
    }
}