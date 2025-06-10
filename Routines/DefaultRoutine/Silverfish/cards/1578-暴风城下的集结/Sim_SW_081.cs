using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_081 : SimTemplate //* 瓦里安，暴风城国王 Varian, King of Stormwind
	{
        //[x]<b>Battlecry:</b> Draw a <b>Rush</b>minion to gain <b>Rush</b>.Repeat for <b>Taunt</b> and<b>Divine Shield</b>.
        //<b>战吼：</b>抽一张<b>突袭</b>随从牌以获得<b>突袭</b>。依此法检定是否可获得<b>嘲讽</b>和<b>圣盾</b>。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //int cnt = 3;
            bool foundRush = false;
            bool foundShield = false;
            bool foundTank = false;
            p.evaluatePenality += 10;

            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckMinion = CardDB.Instance.getCardDataFromID(deckCard);
                if (deckMinion.Rush && !foundRush)
                {
                    p.drawACard(deckCard, own.own, false);
                    Helpfunctions.Instance.ErrorLog("瓦里安，暴风城国王抽" + deckMinion.nameCN + "？");
                    foundRush = true;
                    p.minionGetRush(own);
                    p.evaluatePenality -= 10;
                }
                if (deckMinion.Shield && !foundShield)
                {
                    p.drawACard(deckCard, own.own, false);
                    Helpfunctions.Instance.ErrorLog("瓦里安，暴风城国王抽" + deckMinion.nameCN + "？");
                    foundShield = true;
                    own.divineshild = true;
                    p.evaluatePenality -= 10;
                }
                if (deckMinion.tank && !foundTank)
                {
                    p.drawACard(deckCard, own.own, false);
                    Helpfunctions.Instance.ErrorLog("瓦里安，暴风城国王抽" + deckMinion.nameCN + "？");
                    foundTank = true;
                    own.taunt = true;
                    p.evaluatePenality -= 10;
                    p.anzOwnTaunt++;
                }
            }            
        }
    }
}
