using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_WC_032 : SimTemplate //* 淡云圆盾 Seedcloud Buckler
	{
        //[x]<b>Deathrattle:</b> Give your_minions <b>Divine Shield</b>.
        //<b>亡语：</b>使你的所有随从获得<b>圣盾</b>。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WC_032), true);
        }

        //public override void onHeroattack(Playfield p, Minion own, Minion target)
        //{
        //    if(p.ownWeapon.Durability == 1)
        //    {
        //        foreach(Minion m in p.ownMinions)
        //        {
        //            m.divineshild = true;
        //        }
        //    }
        //}

        public override void onDeathrattle(Playfield p, Minion m)
        {
            foreach (Minion mm in p.ownMinions)
            {
                mm.divineshild = true;
            }
        }
    }
}
