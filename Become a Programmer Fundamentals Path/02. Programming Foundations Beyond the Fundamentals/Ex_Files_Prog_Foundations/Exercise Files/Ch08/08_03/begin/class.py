class Attendee:
    'Common base class for all attendees'

    def __init__(self, name, tickets):
        self.name = name
        self.tickets = tickets

    def displayAttendee(self):
        print('Name : {}, Tickets: {}'.format(self.name, self.tickets))

    def addTicket(self):
        self.tickets += 1
        print('{} tickets increased to {}'.format(self.name, self.tickets))

atendee1 = Attendee('Daniel', 2)
atendee2 = Attendee('Marius', 1)

atendee2.addTicket()
atendee2.addTicket()

atendee1.displayAttendee()
atendee2.displayAttendee()