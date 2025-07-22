using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_YOP_009 : SimTemplate //* 开赛集结 Rally!
	{
        //Resurrect a friendly1-Cost, 2-Cost, and3-Cost minion.
        //复活法力值消耗为（1），（2），（3）的友方随从各一个，        CardDB.Card kid = null;
        public override void onCardPlay(Playfield p, bool ownplay, Minion m, int choice)
        {
            bool cost1 = false;
            bool cost2 = false;
            bool cost3 = false;
            string str = "我寻思开赛集结应该会召唤：";
            int pos = p.ownMinions.Count ;
            p.evaluatePenality += 10;

            foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownGraveyard)
            {
                bool died = true;
                // 如果就在场上不认为已死亡
                foreach ( Minion mm in p.ownMinions ){
                    if(mm.handcard.card.cardIDenum == e.Key && e.Value < 2){
                        died = false;
                        break;;
                    }
                }
                // 死亡随从
                CardDB.Card rebornMob = CardDB.Instance.getCardDataFromID(e.Key);
                // 不是已死亡随从退出
                if(!died || rebornMob.type != CardDB.cardtype.MOB) continue;
                pos = p.ownMinions.Count ;
                if(!cost1 && rebornMob.cost == 1){
                    p.callKid(rebornMob, pos, ownplay);
                    str += rebornMob.nameCN + " ";
                    cost1 = true;
                }
                if(!cost2 && rebornMob.cost == 2){
                    p.callKid(rebornMob, pos, ownplay);
                    str += rebornMob.nameCN + " ";
                    cost2 = true;
                }
                if(!cost3 && rebornMob.cost == 3){
                    p.callKid(rebornMob, pos, ownplay);
                    str += rebornMob.nameCN + " ";
                    cost3 = true;
                }
            }
            //Helpfunctions.Instance.ErrorLog(str);
        }
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
    }
}
