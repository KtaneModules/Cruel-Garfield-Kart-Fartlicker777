using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;
using UnityEngine.Video;

public class CruelGarfieldKart : MonoBehaviour
{

		public KMBombInfo Bomb;
    public KMAudio Audio;
    public VideoPlayer WhateverIwant;
    public KMSelectable[] Buttons;
    public Material[] Ifunnydotco;
    public GameObject Screen;
    public GameObject Douche;
    public Material[] Color;

		private List<string> video = new List<string> {"City1", "City2", "City3", "Danger1", "Danger2", "Danger3", "Hamburger1", "Hamburger2", "Hamburger3", "Hood1", "Hood2", "Hood3", "Incest1", "Incest2", "Incest3", "Iran1", "Iran2", "Iran3", "Lake1", "Lake2", "Lake3", "Last1", "Last2", "Last3", "Mall1", "Mall2", "Mall3", "Manor1", "Manor2", "Manor3", "Oasis1", "Oasis2", "Oasis3", "Pasta1", "Pasta2", "Pasta3", "Pirate1", "Pirate2", "Pirate3", "Pyramid1", "Pyramid2", "Pyramid3", "Skate1", "Skate2", "Skate3", "SneakAPeak1", "SneakAPeak2", "SneakAPeak3"};
    private List<string> trackname = new List<string>{"City Slicker", "City Slicker", "City Slicker", "Prohibited Site", "Prohibited Site", "Prohibited Site", "Play Misty For Me", "Play Misty For Me", "Play Misty For Me", "Catz in the Hood", "Catz in the Hood", "Catz in the Hood", "Country Bumpkin", "Country Bumpkin", "Country Bumpkin", "Crazy Dunes", "Crazy Dunes", "Crazy Dunes", "Palerock Lake", "Palerock Lake", "Palerock Lake", "Valley of the Kings", "Valley of the Kings", "Valley of the Kings", "Mally Market", "Mally Market", "Mally Market", "Spooky Manor", "Spooky Manor", "Spooky Manor", "Blazing Oasis", "Blazing Oasis", "Blazing Oasis", "Pastacosi Factory", "Pastacosi Factory", "Pastacosi Factory", "Loopy Lagoon", "Loopy Lagoon", "Loopy Lagoon", "Mysterious Temple", "Mysterious Temple", "Mysterious Temple", "Caskou Park", "Caskou Park", "Caskou Park", "Sneak-A-Peak", "Sneak-A-Peak", "Sneak-A-Peak"};
    private List<int> cupnumber = new List<int> {2, 2, 2, 4, 4, 4, 3, 3, 3, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3, 3};
    private List<int> videonumber = new List<int> {2, 1, 1, 4, 1, 1, 3, 4, 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 2, 2, 1, 1, 1, 1, 1, 3, 2, 2, 2, 1, 3, 3, 2, 3, 2, 1, 1, 5, 1, 1, 3, 1, 1, 2, 1, 1}; //How they placed in the video
    private List<int> videonumbers = new List<int> {2, 2, 2, 1, 3, 2, 1, 4, 1, 1, 0, 1, 3, 4, 3, 2, 2, 1, 3, 2, 2, 3, 2, 2, 3, 0, 3, 2, 1, 1, 3, 2, 1, 0, 1, 1, 4, 1, 0, 2, 2, 0, 3, 2, 1, 3, 1, 1}; //How many drifts
    private List<int> speedboost = new List<int> {1, 1, 0, 0, 0, 0, 2, 2, 1, 0, 2, 2, 0, 0, 0, 2, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0}; //How many boosts
    private List<string> character = new List<string> {"Garfield", "Odie", "Arlene", "Jon", "Harry", "Squeek", "Liz", "Nermal"};
    private List<int> character36 = new List<int> {134, 69, 109, 66, 115, 132, 74, 117};
    private List<int> characternumber = new List<int> {0, 1, 2, 3, 4, 5, 6, 7};
    private List<int> characternamenumber = new List<int> {869524, 5495, 182545, 54, 81885, 971511, 296, 458312, 425968, 5945, 545281, 45, 58818, 115179, 692, 213854};
    private List<bool> sleepstatus = new List<bool> {false, false, false, false, false, false, false, false, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false}; //Sleep?
    private List<bool> wipeout = new List<bool> {false, false, false, true, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, true, false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false}; //Dead?
    private List<float> Ibewaitingthesebitches = new List<float> {8.5f, 9.5f, 7.5f, 7.5f, 11.5f, 8.5f, 12.5f, 18.5f, 12.5f, 11.5f, 8.5f, 10.5f, 10.75f, 9.75f, 9.75f, 13.5f, 8.5f, 9.5f, 8.5f, 10.75f, 10.5f, 10.5f, 10.5f, 9.75f, 11.5f, 12.5f, 9.75f, 9.5f, 13.5f, 7.75f, 10.75f, 8.5f, 7.5f, 10.5f, 9.5f, 11.5f, 12.75f, 8.5f, 10.5f, 7.5f, 6.5f, 5.75f, 10.5f, 12.5f, 9.5f, 9.5f, 9.5f, 6.5f};
    private List<int> Cityshitter = new List<int> {};
    private List<int> Finalcalulation = new List<int> {};
    private List<int> Morsenumberdots = new List<int> {0, 1, 2, 3, 4, 5, 4, 3, 2, 1};
    private List<int> SNConcatenated = new List<int> {};
    private List<string> Audiovideo = new List<string> {"City1", "City2", "City3", "Danger1", "Danger2", "Danger3", "Hamburger1", "Hamburger2", "Hamburger3", "Hood1", "Hood2", "Hood3", "Incest1", "Incest2", "Incest3", "Iran1", "Iran2", "Iran3", "Lake1", "Lake2", "Lake3", "Last1", "Last2", "Last3", "Mall1", "Mall2", "Mall3", "Manor1", "Manor2", "Manor3", "Oasis1", "Oasis2", "Oasis3", "Pasta1", "Pasta2", "Pasta3", "Pirate1", "Pirate2", "Pirate3", "Pyramid1", "Pyramid2", "Pyramid3", "Skate1", "Skate2", "Skate3", "SneakAPeak1", "SneakAPeak2", "SneakAPeak3"};
    private List<string> cupnamesforlog = new List<string> {"Lasagna", "Lasagna", "Lasagna", "Ice Cream", "Ice Cream", "Ice Cream", "Hamburger", "Hamburger", "Hamburger", "Lasagna", "Lasagna", "Lasagna", "Pizza", "Pizza", "Pizza", "Lasagna", "Lasagna", "Lasagna", "Lasagna", "Lasagna", "Lasagna", "Pizza", "Pizza", "Pizza", "Pizza", "Pizza", "Pizza", "Pizza", "Pizza", "Pizza", "Hamburger", "Hamburger", "Hamburger", "Hamburger", "Hamburger", "Hamburger", "Ice Cream", "Ice Cream", "Ice Cream", "Ice Cream", "Ice Cream", "Ice Cream", "Ice Cream", "Ice Cream", "Ice Cream", "Hamburger", "Hamburger", "Hamburger"};
    private List<string> fanfare = new List<string> {"Fanfare"};

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;
    int fatassretard = 0;
    int startingbullshit = 69;
    int urethralinfection = 69;
    int startingretard = 69;
    int calculatingnumber = 0;
    int tokyodrift = 69;
    int binary = 0;
    int cumchalice = 420; //Thanks Kiki
    int nonbinary = 0;
    string Base36 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int total = 0;
    int pleasesomethingstupid = 0; //input
    int Temptime = 0;
    bool poopyhead = true;
    int Ifunnydotcotwo = 0;

    void Awake()
	{
		moduleId = moduleIdCounter++;
        foreach (KMSelectable Button in Buttons)
		{
            Button.OnInteract += delegate () { ButtonPress(Button); return false; };
        }
    }

    void Start()
	{
		StartCoroutine (Ihavenoideawhatthisis());
	}

    void ButtonPress (KMSelectable Button)
	{
		Button.AddInteractionPunch();
		GetComponent<KMAudio>().PlayGameSoundAtTransform(KMSoundOverride.SoundEffect.ButtonPress, transform);
		if (moduleSolved)
		{
			return;
		}

		if (Button == Buttons[0])
		{
			if (fatassretard < 1)
			{
				if (poopyhead)
				{
					fatassretard = fatassretard + 1;
				}
			}

			else
			{
				pleasesomethingstupid = pleasesomethingstupid * 10 + 1;
			}
        }

		else if (Button == Buttons[1])
		{
			if (fatassretard == 1)
			{
				pleasesomethingstupid = pleasesomethingstupid * 10 + 2;
			}
		}

		else if (Button == Buttons[2])
		{
			if (fatassretard == 1)
			{
				pleasesomethingstupid = pleasesomethingstupid * 10 + 3;
			}
		}

		else if (Button == Buttons[3])
		{
			if (fatassretard == 1)
			{
				pleasesomethingstupid = pleasesomethingstupid * 10 + 4;
			}
		}

		else if (Button == Buttons[4])
		{
			if (fatassretard == 1)
			{
				pleasesomethingstupid = pleasesomethingstupid * 10 + 5;
			}
		}

		else if (Button == Buttons[5])
		{
			if (fatassretard < 1 && poopyhead)
			{
				Douche.GetComponent<MeshRenderer>().material = Color[0];
				WhateverIwant.clip = VideoLoader.clips[startingbullshit];
				WhateverIwant.Play();
				StartCoroutine(Ibeviewingthesebitches());
			}

			else if (fatassretard == 1)
			{
				pleasesomethingstupid = pleasesomethingstupid * 10 + 6;
			}
		}

		else
		{
			Debug.Log("retard");
		}

		if (pleasesomethingstupid > 99999)
		{
			if (pleasesomethingstupid == cumchalice)
			{
				Screen.GetComponent<MeshRenderer>().material = Ifunnydotco[Ifunnydotcotwo];
				GetComponent<KMBombModule>().HandlePass();
				Debug.LogFormat("[Cruel Garfield Kart #{0}] You have inputted {1}. Module disarmed.", moduleId, cumchalice);
				Audio.PlaySoundAtTransform(fanfare[0], transform);
				poopyhead = false;
				moduleSolved = true;
			}

			else if (!moduleSolved)
			{
				GetComponent<KMBombModule>().HandleStrike();
				Debug.LogFormat("[Cruel Garfield Kart #{0}] You have inputted {1}. Strike, dill hole.", moduleId, pleasesomethingstupid);
				pleasesomethingstupid = 0;
				fatassretard = 0;
			}
		}
    }

    private IEnumerator Ibeviewingthesebitches()
	{
		poopyhead = false;
		Playing = true;
		Audio.PlaySoundAtTransform(Audiovideo[startingbullshit], transform);
		yield return new WaitForSeconds(Ibewaitingthesebitches[startingbullshit]);
		WhateverIwant.Stop();
		poopyhead = true;
		Playing = false;
		Douche.GetComponent<MeshRenderer>().material = Color[1];
    }

    private IEnumerator Ihavenoideawhatthisis()
	{
		Ifunnydotcotwo = UnityEngine.Random.Range(0, Ifunnydotco.Count());
		yield return new WaitUntil(() => VideoLoader.clips != null);
		startingbullshit = UnityEngine.Random.Range(0, video.Count());
		urethralinfection = videonumber[startingbullshit];
		tokyodrift = videonumbers[startingbullshit];
		if (Bomb.GetSerialNumber().Any(ch => "GARFIELD".Contains(ch)))
		{
			if (Bomb.GetSerialNumber().Any(ch => "KART".Contains(ch)))
			{
				if (Bomb.GetOnIndicators().Any(x => new[] { "G", "A", "R", "F", "I", "E", "L", "D", "K", "T"}.Any(y => x.Contains(y))))
				{
					startingretard = characternumber[2];
				}

				else
				{
					startingretard = characternumber[1];
				}
			}

			else if (Bomb.GetOnIndicators().Any(x => new[] { "G", "A", "R", "F", "I", "E", "L", "D", "K", "T"}.Any(y => x.Contains(y))))
			{
				startingretard = characternumber[7];
			}

			else
			{
				startingretard = characternumber[0];
			}
        }

		else if (Bomb.GetSerialNumber().Any(ch => "KART".Contains(ch)))
		{
			if (Bomb.GetOnIndicators().Any(x => new[] { "G", "A", "R", "F", "I", "E", "L", "D", "K", "T" }.Any(y => x.Contains(y))))
			{
				startingretard = characternumber[4];
			}

			else
			{
				startingretard = characternumber[6];
			}
        }

        else if (Bomb.GetOnIndicators().Any(x => new[] { "G", "A", "R", "F", "I", "E", "L", "D", "K", "T" }.Any(y => x.Contains(y))))
		{
			startingretard = characternumber[5];
        }

        else
		{
			startingretard = characternumber[3];
        }

		SNConcatenated = Bomb.GetSerialNumberNumbers().ToList();
		Debug.LogFormat("[Cruel Garfield Kart #{0}] The selected character is {1}.", moduleId, character[startingretard]);
        if (Bomb.IsIndicatorOn(Indicator.BOB))
		{
			calculatingnumber = (characternamenumber[startingretard + 8] * urethralinfection) % 1000000;
			Debug.LogFormat("[Cruel Garfield Kart #{0}] Their name in numbers, with respect to BOB, is {1}.", moduleId, characternamenumber[startingretard]);
			Debug.LogFormat("[Cruel Garfield Kart #{0}] There has been {1} drift(s).", moduleId, videonumbers[startingbullshit]);
			Debug.LogFormat("[Cruel Garfield Kart #{0}] Your starting value is {1}.", moduleId, calculatingnumber);
        }

        else
		{
			calculatingnumber = (characternamenumber[startingretard] * urethralinfection) % 1000000;
			Debug.LogFormat("[Cruel Garfield Kart #{0}] Their name in numbers is {1}.", moduleId, characternamenumber[startingretard]);
			Debug.LogFormat("[Cruel Garfield Kart #{0}] There has been {1} drift(s).", moduleId, videonumbers[startingbullshit]);
			Debug.LogFormat("[Cruel Garfield Kart #{0}] Your starting value is {1}.", moduleId, calculatingnumber);
        }

        if (tokyodrift != 0)
		{
			calculatingnumber = calculatingnumber / tokyodrift;
        }

        Debug.LogFormat("[Cruel Garfield Kart #{0}] Adjusting your number by drifts gives you {1}.", moduleId, calculatingnumber);
        Temptime = calculatingnumber;
        while (Temptime != 0)
		{
			if (Temptime % 2 == 0)
			{
				nonbinary += 1;
      }

			else
			{
				binary += 1;
            }

            Temptime >>= 1;
        }

        if (binary == 0)
		{
			calculatingnumber = calculatingnumber; //This is necessary in order to not break fucking everything
        }

        else
		{
			calculatingnumber = calculatingnumber / binary;
        }

        Debug.LogFormat("[Cruel Garfield Kart #{0}] The amount of 1's in the binary equavalent of your number is {1}. Your new number is {2}.", moduleId, binary, calculatingnumber);
        if (sleepstatus[startingbullshit])
		{
			calculatingnumber += 522;
			Debug.LogFormat("[Cruel Garfield Kart #{0}] The player fell asleep, your new number is {1}.", moduleId, calculatingnumber);
        }

        if (cupnumber[startingbullshit] == 1)
		{
			calculatingnumber += 69;
        }
        else if (cupnumber[startingbullshit] == 2)
		{
			calculatingnumber +=420;
        }
        else if (cupnumber[startingbullshit] == 3)
		{
			calculatingnumber -= 69420;
			if (calculatingnumber < 0)
			{
				calculatingnumber += 1000000;
			}
        }

        else
		{
			calculatingnumber -= 42069;
			if (calculatingnumber < 0)
			{
				calculatingnumber += 1000000;
			}
        }

        Debug.LogFormat("[Cruel Garfield Kart #{0}] You are in cup {1}. Adjusting by this cup gives you {2}.", moduleId, cupnamesforlog[startingbullshit], calculatingnumber);
        if (speedboost[startingbullshit] == 2)
		{
			calculatingnumber *= 11;
			Debug.LogFormat("[Cruel Garfield Kart #{0}] The player hit two speed boosts. Multiplying by 11 gives you {1}.", moduleId, calculatingnumber);
        }

        else if (speedboost[startingbullshit] == 1)
		{
			calculatingnumber += 1;
			Debug.LogFormat("[Cruel Garfield Kart #{0}] The player hit one speed boost. Adding 1 gives you {1}.", moduleId, calculatingnumber);
        }

        if (wipeout[startingbullshit])
		{
			calculatingnumber = (int)(((long)calculatingnumber * (long)calculatingnumber) % 1000000);
			Debug.LogFormat("[Cruel Garfield Kart #{0}] You got hit by a pie or a diamond. Squaring your number gives you {1}.", moduleId, calculatingnumber);
        }

        switch (startingbullshit)
		{
			case 0: case 1: case 2: //City
			if (calculatingnumber < 10)
			{
				calculatingnumber = calculatingnumber * 100000;
			}

			else if (calculatingnumber < 100)
			{
				calculatingnumber = calculatingnumber * 10000;
			}

			else if (calculatingnumber < 1000)
			{
				calculatingnumber = calculatingnumber * 1000;
			}

			else if (calculatingnumber < 10000)
			{
				calculatingnumber = calculatingnumber * 100;
			}

			else if (calculatingnumber < 100000)
			{
				calculatingnumber = calculatingnumber * 10;
			}

			Cityshitter.Add(((calculatingnumber % 1000000 - calculatingnumber % 100000) / 100000));
			Cityshitter.Add(((calculatingnumber % 100000 - calculatingnumber % 10000) / 10000));
			Cityshitter.Add(((calculatingnumber % 10000 - calculatingnumber % 1000) / 1000));
			Cityshitter.Add(((calculatingnumber % 1000 - calculatingnumber % 100) / 100));
			Cityshitter.Add(((calculatingnumber % 100 - calculatingnumber % 10) / 10));
			Cityshitter.Add((calculatingnumber % 10));
			calculatingnumber = (Cityshitter[0]*100000)+(Cityshitter[2]*10000)+(Cityshitter[4]*1000)+(Cityshitter[1]*100)+(Cityshitter[3]*10)+(Cityshitter[5]);
			break;

			case 3: case 4: case 5: //Danger
			if (character[startingretard] == "Garfield" || character[startingretard] == "Harry" || character[startingretard] == "Nermal" || character[startingretard] == "Arlene")
			{
			calculatingnumber = calculatingnumber / 9;
			}
			break;

			case 6: case 7: case 8: //Hamburger
			calculatingnumber = 666661;
			break;

			case 9: case 10: case 11: //Hood
			if (calculatingnumber < 10)
			{
				calculatingnumber = calculatingnumber * 100000;
			}

			else if (calculatingnumber < 100)
			{
				calculatingnumber = calculatingnumber * 10000;
			}

			else if (calculatingnumber < 1000)
			{
				calculatingnumber = calculatingnumber * 1000;
			}

			else if (calculatingnumber < 10000)
			{
				calculatingnumber = calculatingnumber * 100;
			}

			else if (calculatingnumber < 100000)
			{
				calculatingnumber = calculatingnumber * 10;
			}

			Cityshitter.Add(((calculatingnumber % 1000000 - calculatingnumber % 100000) / 100000));
			Cityshitter.Add(((calculatingnumber % 100000 - calculatingnumber % 10000) / 10000));
			Cityshitter.Add(((calculatingnumber % 10000 - calculatingnumber % 1000) / 1000));
			Cityshitter.Add(((calculatingnumber % 1000 - calculatingnumber % 100) / 100));
			Cityshitter.Add(((calculatingnumber % 100 - calculatingnumber % 10) / 10));
			Cityshitter.Add((calculatingnumber % 10));
			calculatingnumber = (Cityshitter[5]*100000)+(Cityshitter[4]*10000)+(Cityshitter[3]*1000)+(Cityshitter[2]*100)+(Cityshitter[1]*10)+(Cityshitter[0]);
			break;

			case 12: case 13: case 14: //Incest
			calculatingnumber = (calculatingnumber + 8) % 1000000;
			break;

			case 15: case 16: case 17: //Iran
				nonbinary = 0;
				Temptime = calculatingnumber;
        while (Temptime != 0)
		{
			if (Temptime % 2 == 0)
			{
				nonbinary += 1;
      }
            Temptime >>= 1;
        }
				if (nonbinary != 0) {
					calculatingnumber = calculatingnumber / nonbinary;
				}
			break;
			case 18: case 19: case 20: //Lake
			calculatingnumber = (calculatingnumber * calculatingnumber) % 1000000;
			break;

			case 21: case 22: case 23: //Last
			calculatingnumber = (int)Math.Log10(calculatingnumber);
			break;

			case 24: case 25: case 26: //Mall
			calculatingnumber = calculatingnumber / character36[startingretard];
			break;

			case 27: case 28: case 29: //Manor
			calculatingnumber = ((calculatingnumber - 1) % 9) + 1;
			break;

			case 30: case 31: case 32: //Oasis
			calculatingnumber = calculatingnumber % 6494;
			break;

			case 33: case 34: case 35: //Pasta
			Cityshitter.Add(((calculatingnumber % 1000000 - calculatingnumber % 100000) / 100000));
			Cityshitter.Add(((calculatingnumber % 100000 - calculatingnumber % 10000) / 10000));
			Cityshitter.Add(((calculatingnumber % 10000 - calculatingnumber % 1000) / 1000));
			Cityshitter.Add(((calculatingnumber % 1000 - calculatingnumber % 100) / 100));
			Cityshitter.Add(((calculatingnumber % 100 - calculatingnumber % 10) / 10));
			Cityshitter.Add((calculatingnumber % 10));
			calculatingnumber = calculatingnumber / (Morsenumberdots[Cityshitter[0]]+Morsenumberdots[Cityshitter[1]]+Morsenumberdots[Cityshitter[2]]+Morsenumberdots[Cityshitter[3]]+Morsenumberdots[Cityshitter[4]]+Morsenumberdots[Cityshitter[5]]);
			break;

			case 36: case 37:case 38: //Pirate serial number
			for (int n = 0; n < 6; n++)
			{
				for (int p = 0; p < 36; p++)
				{
					if (Bomb.GetSerialNumber()[n] == Base36[p])
					{
						total += p;
					}
				}
			}

			if (total == 0)
			{
				Debug.Log("Okay but how");
			}

			else
			{
				total /= 6;
				calculatingnumber /= total;
			}
			break;

			case 39: case 40: case 41: //Pyramid serial number
			if (SNConcatenated.Count == 4 && (SNConcatenated[0] * 1000 + SNConcatenated[1] * 100 + SNConcatenated[2] * 10 + SNConcatenated[3]) != 0)
			{
				calculatingnumber /= (SNConcatenated[0] * 1000 + SNConcatenated[1] * 100 + SNConcatenated[2] * 10 + SNConcatenated[3]);
			}

			else if (SNConcatenated.Count == 3 && (SNConcatenated[0] * 100 + SNConcatenated[1] * 10 + SNConcatenated[2]) != 0)
			{
				calculatingnumber /= (SNConcatenated[0] * 100 + SNConcatenated[1] * 10 + SNConcatenated[2]);
			}

			else if (SNConcatenated.Count == 2 && (SNConcatenated[0] * 10 + SNConcatenated[1]) != 0)
			{
				calculatingnumber /= (SNConcatenated[0] * 10 + SNConcatenated[1]);
			}

			else
			{
				Debug.Log("You fucked up.");
			}
			break;

			case 42: case 43: case 44: //Skate
			calculatingnumber = ((calculatingnumber * 100) + 17) % 1000000;
			break;

			case 45: case 46: case 47: //SneakAPeak
			calculatingnumber = (int)Math.Sqrt(calculatingnumber);
			break;

			default:
			Debug.Log("Oh fuck");
			break;
        }

        if (calculatingnumber < 0)
		{
			calculatingnumber += 1000000;
        }

		Finalcalulation.Add(((calculatingnumber % 1000000 - calculatingnumber % 100000) / 100000));
		Finalcalulation.Add(((calculatingnumber % 100000 - calculatingnumber % 10000) / 10000));
		Finalcalulation.Add(((calculatingnumber % 10000 - calculatingnumber % 1000) / 1000));
		Finalcalulation.Add(((calculatingnumber % 1000 - calculatingnumber % 100) / 100));
		Finalcalulation.Add(((calculatingnumber % 100 - calculatingnumber % 10) / 10));
		Finalcalulation.Add((calculatingnumber % 10));

		for (int x = 0; x < 6; x++)
		{
			if (Finalcalulation[x] > 6)
			{
				Finalcalulation[x] = Finalcalulation[x] % 6;
            }

            else if (Finalcalulation[x] == 0)
			{
				Finalcalulation[x] = 6;
            }
		}

		Debug.LogFormat("[Cruel Garfield Kart #{0}] The track you are in is {1}. Adjusting by the track gives you {2}.", moduleId, trackname[startingbullshit], calculatingnumber);
		cumchalice = Finalcalulation[0] * 100000 + Finalcalulation[1] * 10000 + Finalcalulation[2] * 1000 + Finalcalulation[3] * 100 + Finalcalulation[4] * 10 + Finalcalulation[5];
		if (Bomb.GetBatteryCount() == 24 && Bomb.GetBatteryHolderCount() == 12)
		{
			cumchalice = 111111;
			Debug.LogFormat("[Cruel Garfield Kart #{0}] There are 24 batteries in 12 holders, press 111111.", moduleId);
		}

		Debug.LogFormat("[Cruel Garfield Kart #{0}] The final number is {1}.", moduleId, cumchalice);
	}

	//twitch plays
    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"To play the video in the screen, use the command !{0} play, or !{0} playfocus | To submit a button sequence in the module, use the command !{0} submit [6-digit number]";
    #pragma warning restore 414

	string[] ValidSpins = {"1", "2", "3", "4", "5", "6"};
	bool Playing = false;

	IEnumerator ProcessTwitchCommand(string command)
	{
		string[] parameters = command.Split(' ');
		if (Regex.IsMatch(command, @"^\s*play\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			yield return null;
			if (Playing)
			{
				yield return "sendtochaterror The video is already playing.";
				yield break;
			}
			Buttons[5].OnInteract();
		}

		if (Regex.IsMatch(command, @"^\s*playfocus\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			yield return null;
			if (Playing)
			{
				yield return "sendtochaterror The video is already playing.";
				yield break;
			}
			Buttons[5].OnInteract();
			yield return null;
			while (Playing)
			{
				yield return null;
			}
		}

		if (Regex.IsMatch(parameters[0], @"^\s*submit\s*$", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant))
		{
			yield return null;
			if (parameters.Length != 2)
			{
				yield return "sendtochaterror Parameter length is invalid.";
				yield break;
			}

			if (Playing)
			{
				yield return "sendtochaterror You can't submit yet while the video is still playing.";
				yield break;
			}

			foreach (char c in parameters[1])
			{
				if (!c.ToString().EqualsAny(ValidSpins))
				{
					yield return "sendtochaterror A button being pressed is not between 1-6.";
					yield break;
				}
			}

			if (parameters[1].Length != 6)
			{
				yield return "sendtochaterror The number length is not 6 digits.";
				yield break;
			}

			Buttons[0].OnInteract();
			yield return new WaitForSecondsRealtime(0.2f);

			foreach (char d in parameters[1])
			{
				Buttons[Int32.Parse(d.ToString())-1].OnInteract();
				yield return new WaitForSecondsRealtime(0.2f);
			}
		}
	}
}
