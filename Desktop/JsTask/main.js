const persons = [
  {
    id: 1,
    firstname: "Dan",
    lastname: "Tiger",
    image: "url",
    birthday: "03.18.1990",
    gender: "male",
    hobbie: ["Football", "Reading"],
    nationality: "switzerland",
    friends: [325330, 325334],
    residence: 10041
  },
  {
    id: 2,
    firstname: "Fan",
    lastname: "Tiger",
    image: "url",
    birthday: "03.18.2005",
    gender: "male",
    hobbie: ["Football", "Reading"],
    nationality: "switzerland",
    friends: [325330, 325334],
    residence: 10041
  },
  {
    id: 3,
    firstname: "Frank",
    lastname: "Lion",
    image: "url",
    birthday: "10.05.1991",
    gender: "male",
    hobbie: ["walking", "basketball"],
    nationality: "syria",
    friends: ["", "", ""],
    residence: 10041
  },
  {
    id: 4,
    firstname: "Bilal",
    lastname: "Zakki",
    image: "url",
    birthday: "08.19.1999",
    gender: "female",
    hobbie: ["swimming", "walking"],
    nationality: "canda",
    friends: [325330, 325326],
    residence: 10012
  },
  {
    id: 10,
    firstname: "Omar",
    lastname: "Khaled",
    image: "url",
    birthday: "01.11.2001",
    gender: "male",
    hobbie: ["basketball", "swimming"],
    nationality: "jordan",
    friends: [],
    residence: 10041
  },
  {
    id: 11,
    firstname: "Maria",
    lastname: "Costa",
    image: "url",
    birthday: "02.24.1992",
    gender: "female",
    hobbie: ["traveling", "reading"],
    nationality: "portugal",
    friends: [325333],
    residence: 10025
  },
  {
    id: 12,
    firstname: "Eren",
    lastname: "Demir",
    image: "url",
    birthday: "05.10.1997",
    gender: "male",
    hobbie: ["gym", "movies"],
    nationality: "turkey",
    friends: [],
    residence: 10041
  },
  {
    id: 13,
    firstname: "Nora",
    lastname: "Schmidt",
    image: "url",
    birthday: "11.03.1989",
    gender: "female",
    hobbie: ["painting", "hiking"],
    nationality: "austria",
    friends: [325326, 325334],
    residence: 10010
  },
  {
    id: 14,
    firstname: "Hakim",
    lastname: "Rahman",
    image: "url",
    birthday: "03.03.1994",
    gender: "male",
    hobbie: ["football", "programming"],
    nationality: "morocco",
    friends: [],
    residence: 10014
  }
];

function findById(arr, id) {
    return arr.find(p => p.id === id);
}
console.log(findById(persons,1))


function filterByGender(arr, gender) {
    return arr.filter(p => p.gender === gender);
}
console.log(filterByGender(persons,"male"))

const newPerson1 = { id: 99, firstname: "Emrah", lastname: "Akhmedzade", gender:"male" };
persons.unshift(newPerson1);
console.log(persons)

const newPerson2 = { id: 100, firstname: "Ayshan", lastname: "Adigozelova", gender:"female" };
persons.push(newPerson2);
console.log(persons)

persons.splice(5, 3,
    { id: 200, firstname: "A", lastname: "A", gender:"male" },
    { id: 201, firstname: "B", lastname: "B", gender:"female" },
    { id: 202, firstname: "C", lastname: "C", gender:"male" }
);






