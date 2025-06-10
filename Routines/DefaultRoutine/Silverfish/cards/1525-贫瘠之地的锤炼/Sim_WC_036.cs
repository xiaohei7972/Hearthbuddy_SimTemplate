using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_036 : SimTemplate //* 变异尖牙风蛇 Deviate Dreadfang
	{
        //After you cast a Nature spell, summon a 4/2 Viper with <b>Rush</b>.
        //在你施放一个自然法术后，召唤一条4/2并具有<b>突袭</b>的飞蛇。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Minion triggerEffectMinion)
        {
            if (triggerEffectMinion.own)
            {
                if(hc.card.SpellSchool == CardDB.SpellSchool.NATURE)
                {
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_036t1), triggerEffectMinion.zonepos, true);
                }
            }
        }

    }
}
