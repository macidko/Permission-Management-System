import "./Login.css";
import { Container, Form, Button } from "react-bootstrap";

const Login = () => {
  return (
    <Container fluid className="vh-100 bg-success d-flex align-items-center justify-content-center">
    <Form className="bg-warning p-5 rounded">
      <Form.Group className="text-center text-white h1">
        <Form.Label className="font-weight-bold">LOGIN</Form.Label>
      </Form.Group>
      <Form.Group className="mb-3" controlId="formBasicEmail">
        <Form.Label>Email address</Form.Label>
        <Form.Control type="email" placeholder="Enter email" />
        <Form.Text className="text-muted">
          We'll never share your email with anyone else.
        </Form.Text>
      </Form.Group>

      <Form.Group className="mb-3" controlId="formBasicPassword">
        <Form.Label>Password</Form.Label>
        <Form.Control type="password" placeholder="Password" />
      </Form.Group>
      <Button variant="primary" type="submit" className="float-end">
        Login
      </Button>
    </Form>
  </Container>
  );
};

export default Login;
