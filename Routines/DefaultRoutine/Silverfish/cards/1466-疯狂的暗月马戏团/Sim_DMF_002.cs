using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DMF_002 : SimTemplate //* 恩佐斯，深渊之神 N'Zoth, God of the Deep
	{
        //<b>Battlecry:</b> Resurrect a friendly minion of each minion type.
        //<b>战吼：</b>随机复活每个随从类型的各一个友方随从。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool[] summon = new bool[100];
            summon[0] = true;
            int pos = 0;
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
                pos = p.ownMinions.Count;
                if(!summon[(int)rebornMob.race] || rebornMob.race == CardDB.Race.ALL)
                {
                    p.callKid(rebornMob, pos, true);
                    summon[(int)rebornMob.race] = true;
                }                
            }
        }

    }
}
