describe('Topic Creation', () => {
  it('should allow a student to create a topic', () => {
    cy.visit('http://localhost:3000');
    cy.get('#title').type('Microservices 101');
    cy.get('#description').type('Intro to distributed systems');
    cy.get('#submit-topic').click();
    cy.contains('Microservices 101').should('exist');
  });
});
