using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_116 : SimTemplate //Kezan Mystic
    {
        //todo better!
        //  Battlecry: Take control of a random enemy Secret;. 

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            SecretItem s = new SecretItem();
            s.canBe_avenge = false;
            s.canBe_sacredtrial = false;
            s.canBe_counterspell = false;
            s.canBe_cattrick = false;
            s.canBe_duplicate = false;
            s.canBe_explosive = false;
            s.canBe_beartrap = false;
            s.canBe_eyeforaneye = false;
            s.canBe_freezing = false;
            s.canBe_icebarrier = false;
            s.canBe_iceblock = false;
            s.canBe_mirrorentity = false;
            s.canBe_missdirection = false;
            s.canBe_darttrap = false;
            s.canBe_noblesacrifice = false;
            s.canBe_redemption = false;
            s.canBe_repentance = false;
            s.canBe_snaketrap = false;
            s.canBe_snipe = false;
            s.canBe_spellbender = false;
            //s.canBe_vaporize = false;

            s.entityId = 1050;
            s.canBe_explosive = true;

            if (own.own && p.ownSecretsIDList.Count <= 4)
            {

            }
            if(!own.own && p.enemySecretList.Count <= 4)
            {
                p.enemySecretList.Add(s);
            }

        }

    }

}